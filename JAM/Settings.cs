using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JAM
{
	public partial class Settings : Form
	{
		public Settings()
		{
			InitializeComponent();
		}
	}

	public enum PasswordProtectionType
	{
		NONE = 0,
		LIMITED = 1,
		FULL = 2
	}
}
