using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Microsoft.SqlServer.Server;

[Serializable]
[Microsoft.SqlServer.Server.SqlUserDefinedType(Format.Native)]
public struct PolygonUDT : INullable
{
    private bool isNull;

    private int numberOfSides;
    private double sideLength;

    public override string ToString()
    {
        if (this.isNull)
            return "null";
        else
            return string.Format("{0} sides and the length of each side is {1} units",
                numberOfSides, sideLength);
    }

    public bool IsNull
    {
        get
        {
            return isNull;
        }
    }

    public static PolygonUDT Null
    {
        get
        {
            PolygonUDT p = new PolygonUDT();
            p.isNull = true;
            return p;
        }
    }

    public static PolygonUDT Parse(SqlString s)
    {
        if (s.IsNull || s.Value.ToLower().Equals("null"))
            return Null;

        string[] str = s.ToString().Split(',');
        if (str.Length != 2)
            return Null;

        PolygonUDT p = new PolygonUDT();

        try
        {
            p.numberOfSides = int.Parse(str[0]);
            p.sideLength = double.Parse(str[1]);

            if (p.numberOfSides > 2 && p.sideLength > 0)
                return p;
            else
                return Null;
        }
        catch (Exception)
        {
            return Null;
        }
    }

    public int NumberOfSides
    {
        get { return numberOfSides; }
        set
        {
            if (value > 2)
            {
                numberOfSides = value;
                isNull = false;
            }
            else
                isNull = true;
        }
    }

    public double SideLength
    {
        get { return sideLength; }
        set
        {
            if (value > 0)
            {
                sideLength = value;
                isNull = false;
            }
            else
                isNull = true;
        }
    }

    [SqlMethod]
    public double PolygonArea()
    {
        if (!isNull)
            return .25 * numberOfSides * Math.Pow(sideLength, 2) *
                 (1 / Math.Tan(Math.PI / numberOfSides));
        else
            return 0;
    }

    [SqlMethod(IsMutator = true, OnNullCall = false)]
    public void UpdateValue(int numberOfSides, double sideLength)
    {
        if (numberOfSides > 2 && sideLength > 0)
        {
            this.numberOfSides = numberOfSides;
            this.sideLength = sideLength;
            this.isNull = false;
        }
        else
            isNull = true;
    }
}


