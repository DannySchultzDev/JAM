/*
Copyright 2025 Wah Infinite

This file is part of JAM.

JAM is free software: you can redistribute it and/or modify it under the terms of the GNU General
Public License as published by the Free Software Foundation, either version 3 of the License, or (at your 
option) any later version.

JAM is distributed in the hope that it will be useful, but WITHOUT ANY WARRANTY; without even 
the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the 
GNU General Public License for more details.

You should have received a copy of the GNU General Public License along with JAM. If not, see 
<https://www.gnu.org/licenses/>.
*/

namespace JAM
{
	public partial class Credits : Form
	{
		#region Lifecycle
		/// <summary>
		/// Base Constructor.
		/// </summary>
		public Credits()
		{
			InitializeComponent();
		}

		/// <summary>
		/// User is done with Credits. So close the window.
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void doneButton_Click(object sender, EventArgs e)
		{
			Close();
		}
		#endregion Lifecycle
	}
}
