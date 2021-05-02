using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime;
using System.Runtime.Remoting;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Channels.Http;
using MathOperation; 

namespace Server
{
    public class ServerClass
    {
        public static void Main(string[] args)
        {
            HttpChannel channel = new HttpChannel(9932);
            ChannelServices.RegisterChannel(channel, false);
            RemotingConfiguration.ApplicationName = "MathOperation";
            RemotingConfiguration.RegisterWellKnownServiceType(typeof(MathOperation.ArithmeticOperation), "ArithmeticOperation", WellKnownObjectMode.SingleCall);
            Console.WriteLine("Server started.");
            Console.ReadLine();
        }
    }
}
