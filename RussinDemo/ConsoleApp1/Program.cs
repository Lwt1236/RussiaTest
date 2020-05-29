using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private Socket socket;
        private void Server()
        {
            var server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            // 绑定服务端IP和端口，客户端通过这个地址连入
            server.Bind(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9356));
            // 开启服务监听，参数为最大挂起队列的连接数（并发），已连接的不计
            server.Listen(1);
            // 这是一个阻塞方法，接收客户端接入，返回客户端连接Socket
            socket = server.Accept();
            Console.WriteLine("Local : {0}\nRemote : {1}", socket.LocalEndPoint.ToString(), socket.RemoteEndPoint.ToString());
            // 数据接收：这是一个异步过程
            ReceiveAsync();
            // 数据发送：这是一个阻塞方法
            Write();
            // 关闭客户端连接Socket和服务Socket
            socket.Close();
            server.Close();
        }
    }
}
