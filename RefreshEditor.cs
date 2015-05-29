using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace PromiseTechnology.DesktopTiles {
    public partial class RefreshEditor : UserControl {
        private CPUTile _Tile;

        public RefreshEditor() {
            InitializeComponent();
        }

        public RefreshEditor(CPUTile tile) : this() {
            _Tile = tile;
            textBox1.Text = _Tile.RefreshRate.ToString();
            textBox1.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e) {
            int result = 0;
            if (int.TryParse(textBox1.Text, out result)) {
                if (result > 0 && result < 10000) {
                    _Tile.RefreshRate = result;
                }
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e) {
            if (e.KeyCode == Keys.Enter) {
                DesktopTiles.ContextMenu.Close();
            }
        }
    }
}
