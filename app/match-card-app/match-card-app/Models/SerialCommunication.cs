using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace dino.Models
{
    class SerialCommunication
    {
        // Create the serial port with basic settings
        public SerialPort Port { get; }

        public SerialCommunication(string comPort, SerialDataReceivedEventHandler handler)
        {
            Port = new SerialPort(comPort, 9600, Parity.None, 8, StopBits.One);
            Console.WriteLine("Incoming Data:");

            // Attach a method to be called when there is data waiting in the port's buffer
            Port.DataReceived += handler;
        }
    }
}
