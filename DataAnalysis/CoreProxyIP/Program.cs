using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace CoreProxyIP
{
    class Program
    {
        static void Main(string[] args)
        {
			//IList<Task> itasks = new List<Task>();
			//CancellationTokenSource isoure = new CancellationTokenSource();
			//CancellationToken itoken = isoure.Token;
			////代理IP监听接口,Task多线程
			//itasks.Add(new Task(() => HtmlRule.Lisener(), itoken));
			////获取代理IP
			//itasks.Add(new Task(() => HtmlRule.Liunian(), itoken));
			//itasks.Add(new Task(() => HtmlRule.Xici(), itoken));
			//itasks.Add(new Task(() => HtmlRule.XiciGaoni(), itoken));
			//itasks.Add(new Task(() => HtmlRule.XiciPutong(), itoken));

			//for (int i = 0; i < itasks.Count; i++)
			//{
			//	itasks[i].Start();
			//}
			//Task.WaitAll(itasks.ToArray(), (4 * 1000), itoken);

			////代理IP监听接口,Task多线程
			//Task.Run(() => HtmlRule.Lisener());

			////获取代理IP
			//Task.Run(() => HtmlRule.Liunian());
			//Task.Run(() => HtmlRule.Xici());
			//Task.Run(() => HtmlRule.XiciGaoni());
			//Task.Run(() => HtmlRule.XiciPutong());

			Task t1 = new Task(HtmlRule.Lisener);t1.Start();
			Task t2 = new Task(HtmlRule.Liunian); t2.Start();
			Task t3 = new Task(HtmlRule.Xici); t3.Start();
			Task t4 = new Task(HtmlRule.XiciGaoni); t4.Start();
			Task t5 = new Task(HtmlRule.XiciPutong); t5.Start();

			Task.WaitAll(t1, t2, t3, t4, t5);

			Console.ReadLine();


        }
    }
}
