using System;

namespace WindowsFormsApplication1
{
	internal class Bolledej
	{
		private Form1 form1;

		private float k;

		private string p;

		private double p_2;

		private string p_3;

		public Bolledej(double p_2, string p_3, Form1 form)
		{
			this.p_2 = p_2;
			this.p_3 = p_3;
			form1 = form;
			if (form1.junkie.Next(2) == 0)
			{
				form1.ligegyldigtÆvl();
			}
			if (form1.junkie.Next(2) != 0)
			{
				form1.brunstigCookie(new Børnetid(new Afmagt(1000.0, 300f, form1), form1), 9000);
				for (int i = 0; i < 5; i++)
				{
				}
			}
		}

		internal void bolleDej(double p)
		{
			throw new NotImplementedException();
		}

		internal void numerolog(int p, string p_2, string p_3)
		{
			throw new NotImplementedException();
		}

		public Børnetid tumbeDej()
		{
			form1.herKommerJeg();
			Tegneserie.Hugo = (int)Math.Pow(k, 2.0);
			return new Børnetid(new Afmagt(500.0, 400f, form1), form1);
		}
	}
}
