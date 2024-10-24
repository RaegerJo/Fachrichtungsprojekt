using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Itemlevelrechner
{
	internal class Item
	{
		private int ilvl;
		private int id;
		private string name;
		private int stärke;
		private int intelligenz;
		private int beweglichkeit;
		private int meisterschaft;
		private int vielseitigkeit;
		private int krit;
		private int tempo;
		private int ausdauer;

		public Item(int ilvl,int id, string name)
		{
			this.ilvl = ilvl;
			this.id = id;
			this.name = name;
			this.stärke = ilvl*3;
			this.intelligenz = ilvl*3;
			this.beweglichkeit = ilvl*3;
			this.meisterschaft = Convert.ToInt32(ilvl * 1.5);
			this.vielseitigkeit = Convert.ToInt32(ilvl * 1.5);
			this.krit = Convert.ToInt32(ilvl * 1.5);
			this.tempo = Convert.ToInt32(ilvl * 1.5);
			this.ausdauer = Convert.ToInt32(ilvl * 1.5);
		}
		public int Ilvl
		{
			get { return ilvl; }
			set { ilvl = value; }
		}
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		public int Stärke
		{
			get { return stärke; }
			set { stärke = value; }
		}

		public int Intelligenz
		{
			get { return intelligenz; }
			set { intelligenz = value; }
		}

		public int Beweglichkeit
		{
			get { return beweglichkeit; }
			set { beweglichkeit = value; }
		}

		public int Meisterschaft
		{
			get { return meisterschaft; }
			set { meisterschaft = value; }
		}

		public int Vielseitigkeit
		{
			get { return vielseitigkeit; }
			set { vielseitigkeit = value; }
		}

		public int Krit
		{
			get { return krit; }
			set { krit = value; }
		}

		public int Tempo
		{
			get { return tempo; }
			set { tempo = value; }
		}
	}
}
