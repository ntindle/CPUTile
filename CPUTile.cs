using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PromiseTechnology;
using PromiseTechnology.DesktopTiles;
using PromiseTechnology.Markup;

namespace PromiseTechnology.DesktopTiles {
    public partial class CPUTile : Tile {
        public CPUTile() : base() {
            InitializeComponent();
            this.WireEvents(this);
            this.performanceGraph1.ChartRunning = true;
            this.label1.Text = "The last " + (performanceGraph1.RefreshRate * performanceGraph1.NumberOfDataPoints / 1000d) + " seconds";

            this.Size = new Size(254, 254);
            this.label1.Location = new Point(65, 219);
            // 126 * new - 2
        }

        public int RefreshRate {
            get {
                return performanceGraph1.RefreshRate;
            }
            set {
                performanceGraph1.RefreshRate = value;
                this.label1.Text = "The last " + (this.RefreshRate * performanceGraph1.NumberOfDataPoints / 1000d) + " seconds";
                this.label1.Invalidate();
                this.label1.Update();
            }
        }

        public override string GetName() {
            return "CPU Monitor";
        }

        public override string GetId() {
            return "NT.CPUTile";
        }

        public override List<ToolStripItem> GetMenuItems() {
            List<ToolStripItem> list = base.GetMenuItems();

            var Edit = ((ToolStripMenuItem)list.First(x => x.Name == "Edit"));
            var Size = Edit.DropDownItems["Edit-Size"];
            var Edit_Refresh = new ToolStripMenuItem() {
                Name = "Edit-Refresh",
                Text = "Refresh Rate",
                DropDownItems = {
                    new ToolStripControlHost(new RefreshEditor(this)) {
                        Name = "Edit-Refresh-Editor"
                    }
                }
            };

            Size.Visible = false;

            (list.RecursiveFind("Edit") as ToolStripMenuItem).DropDownItems.Add(Edit_Refresh);
            return list;
        }

        public override Tile LoadFromMarkup(MarkupDocument doc) {
            List<Node> nodes = doc.RootNode.Children.HasTagText("refresh");

            if (nodes.Count > 0) {
                this.RefreshRate = (int)(nodes.First().InnerObject);
            }

            return base.LoadFromMarkup(doc);
        }

        public override MarkupDocument SaveToMarkup(MarkupDocument doc, ref List<TypeProvider<List<Node>>> nodeProviders) {
            doc.RootNode.Children.Add(new Node() {
                TagText = "refresh",
                InnerObject = this.RefreshRate
            });

            return base.SaveToMarkup(doc, ref nodeProviders);
        }

        public override void OnResizeStart() {
            if (this.IsSmall) {
                this.label1.Visible = false;
            }

            base.OnResizeStart();
        }

        public override void OnResizeFinish() {
            if (!this.IsSmall) {
                this.label1.Visible = true;
            }

            base.OnResizeFinish();
        }
    }
}