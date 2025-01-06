using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgorithmTest
{
	class Program
	{
		static void Main(string[] args)
		{
			string video_len = "34:33";
			string pos = "13:00";
			string op_start = "00:55";
			string op_end = "02:55";
			string[] commands = new string[] { "next", "prev" };
			string answer = "";


			TimeSpan tpPos = new TimeSpan(0, 0, Convert.ToInt16(pos.Substring(0, 2)), Convert.ToInt16(pos.Substring(3, 2)), 0);
			TimeSpan tpOSt = new TimeSpan(0, 0, Convert.ToInt16(op_start.Substring(0, 2)), Convert.ToInt16(op_start.Substring(3, 2)), 0);
			TimeSpan tpOEd = new TimeSpan(0, 0, Convert.ToInt16(op_end.Substring(0, 2)), Convert.ToInt16(op_end.Substring(3, 2)), 0);
			TimeSpan tpEnd = new TimeSpan(0, 0, Convert.ToInt16(video_len.Substring(0, 2)), Convert.ToInt16(video_len.Substring(3, 2)), 0);

			for (int i = 0; i < commands.Length; i++)
			{
				if (commands[i] == "next")
				{
					if (tpOSt <= tpPos && tpPos <= tpOEd)  //이동 후 위치가 오프닝 위치인 경우 건너뛰기
					{
						tpPos = tpOEd;
					}

					tpPos += new TimeSpan(0, 0, 10);

					//남은 시간이 10초 미만일 경우 
					if ((tpEnd - tpPos).TotalSeconds < 10)
					{
						tpPos = tpEnd;
					}
					else if (tpOSt <= tpPos && tpPos <= tpOEd)  //이동 후 위치가 오프닝 위치인 경우 건너뛰기
					{
						tpPos = tpOEd;
					}
				}
				else
				{
					//prev
					if (tpOSt <= tpPos && tpPos <= tpOEd)  //이동 후 위치가 오프닝 위치인 경우 건너뛰기
					{
						tpPos = tpOEd;
					}

					tpPos -= new TimeSpan(0, 0, 10);

					if (tpPos.TotalSeconds < 10)
					{
						tpPos = new TimeSpan(0, 0, 0);
					}
					else if (tpOSt <= tpPos && tpPos <= tpOEd)  //이동 후 위치가 오프닝 위치인 경우 건너뛰기
					{
						tpPos = tpOEd;
					}
				}
			}

			answer = tpPos.ToString(@"mm\:ss");
			Console.Write(answer);

		}
	}
}
