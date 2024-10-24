using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itemlevelrechner
{
	internal class Slot
	{
		private string name;
		private int platz;
		private double ilvl;
		private double mainstat;
		public Slot(string name, int platz)
		{
			this.name = name;
			this.platz = platz;
			this.ilvl = 0;
			this.mainstat = ilvl*3;		
		
		}
		public double Ilvl
		{
			get { return ilvl; }
			set { ilvl = value; }
		}
		public string Name
		{
			get { return name; }
			set { name = value; }
		}
		public int Platz
		{
			get { return platz; }
			set { platz = value; }
		}
		public double Mainstat
		{
			get { return mainstat; }
			set { mainstat = value; }
		}
		public void SetIlvlundMainstat(double ilvl)
		{
			this.ilvl = ilvl;
			this.mainstat = ilvl*3;
		}
	}
}
