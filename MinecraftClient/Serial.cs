using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO.Ports;

namespace MinecraftClient.Commands
{
    public class Serial : Command
    {
        public SerialPort PortsName;
        public override string CMDName { get { return "Serial"; } }
        public override string CMDDesc { get { return "Type the string you would like to send to COM3"; } }
        public override string Run(McTcpClient handler, string command)
        {
            PortsName = new SerialPort();
            PortsName.PortName = "COM3";
                if (!PortsName.IsOpen)
                {
                    try
                    {
                        PortsName.Open();
                        PortsName.WriteLine("b");
                        PortsName.Close();
                        return "YES WORK";
                    }
                    catch
                    {
                        return "NO WORK";
                    }
                }
                return "";
        }
    }
}
