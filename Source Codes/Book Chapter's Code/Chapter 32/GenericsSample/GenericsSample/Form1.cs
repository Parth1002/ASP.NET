using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GenericsSample
{
    public partial class Form1 : Form
    {
        private MyGenericCollection<Arithmetic> MGColA;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "Release All")
            {
                ((Button)sender).Text = "Add Items";
                listBox1.Items.Clear();

                TextBox1.Text = "";

                Button3.Enabled = false;
                Button2.Enabled = false;
                Button4.Enabled = false;

                ReleaseAll();
            }
            else
            {
                ((Button)sender).Text = "Release All";
                Button3.Enabled = true;
                Button2.Enabled = true;
                Button4.Enabled = true;

                DoDeclaration();
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Arithmetic objA1 = MGColA.GetItems(0);
            Arithmetic objA2 = MGColA.GetItems(1);
            TextBox1.Text = Sum(objA1, objA2);
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndices.Count != 0)
            {
                TextBox1.Text = "";

                foreach (int indice in listBox1.SelectedIndices)
                {
                    TextBox1.Text += MGColA.GetItems(indice);
                }

            }
            else
            {
                MessageBox.Show("Please select some items in the listboxes first.");
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            object tempVal = Microsoft.VisualBasic.Interaction.InputBox("Value to Look Up", "", "", -1, -1);
            int tempIndex = 0;

            tempIndex = MGColA.ContainsValue(new Arithmetic(Convert.ToInt32(tempVal)));

            MessageBox.Show(((tempIndex == -1) ? "The collection does not contain the specified value" : "The collection contains the specified value at index = " + tempIndex.ToString()));
        }
        private void ReleaseAll()
        {
            MGColA = null;

            GC.Collect();
        }
        private void DoDeclaration()
        {

            MGColA = new MyGenericCollection<Arithmetic>(4);


            MGColA.SetItems(0, new Arithmetic(1000));
            MGColA.SetItems(1, new Arithmetic(2000));
            MGColA.SetItems(2, new Arithmetic(3000));
            MGColA.SetItems(3, new Arithmetic(4000));
            MGColA.SetItems(4, new Arithmetic(5000));



            for (int i = 0; i <= 4; i++)
            {
                listBox1.Items.Add(MGColA.GetItems(i));

            }
        }
        public string Sum<T>(T val1, T val2) where T : IBase
        {
            return val1.AddIt(val2);
        }

        public void Display<T>(T val1)
        {
            MessageBox.Show(val1.ToString());
        }
    }

}
public interface IBase
{
    string AddIt(IBase obj1);
}
public class MyGenericCollection<Tp>
{

    private Tp[] Arr;

    public MyGenericCollection(int Size)
    {
        Arr = new Tp[Size + 1];
    }

    public Tp GetItems(int index)
    {
        return Arr[index];
    }

    public void SetItems(int index, Tp value)
    {
        Arr[index] = value;
    }

    public int ContainsValue(Tp obj)
    {
        for (int i = 0; i < Arr.Length; i++)
        {
            if (((IEquatable<IBase>)Arr[i]).Equals(obj))
            {
                return i;
            }
        }
        return -1;
    }
}
public class Arithmetic : IEquatable<IBase>, IBase
{

    private int nm;

    public Arithmetic()
    {
        nm = 0;
    }

    public Arithmetic(int Number)
    {
        nm = Number;
    }

    public override bool Equals(object obj)
    {
        Arithmetic bObj = obj as Arithmetic;
        return bObj != null && Equals(bObj);
    }

    public bool Equals(IBase oth)
    {
        return oth != null && nm == ((Arithmetic)oth).nm;
    }

    public string AddIt(IBase obj1)
    {
        return ((int)this.Number + (int)((Arithmetic)obj1).Number).ToString();
    }

    public static string operator +(string obj1, Arithmetic obj2)
    {
        if (obj1 != "")
        {
            return (Convert.ToInt32(obj1) + (int)obj2.Number).ToString();
        }
        return obj2.Number.ToString();
    }

    public static string operator +(Arithmetic obj1, Arithmetic obj2)
    {
        if (obj1 != null)
        {
            return ((int)obj1.Number + (int)obj2.Number).ToString();
        }
        return obj2.Number.ToString();
    }

    public override string ToString()
    {
        return nm.ToString();
    }

    public object Number
    {
        get
        {
            return nm;
        }
        set
        {
            nm = (int)value;
        }
    }
}
