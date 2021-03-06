
// This file has been generated by the GUI designer. Do not modify.
namespace compactCA
{
	public partial class genCRL
	{
		private global::Gtk.Table table3;
		
		private global::Gtk.Entry caPass;
		
		private global::Gtk.Label label1;
		
		private global::Gtk.Label label2;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button cancelCRL;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget catoolgui.genCRL
			this.Name = "catoolgui.genCRL";
			this.Title = global::Mono.Unix.Catalog.GetString ("Generate CRL");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child catoolgui.genCRL.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.caPass = new global::Gtk.Entry ();
			this.caPass.CanFocus = true;
			this.caPass.Name = "caPass";
			this.caPass.IsEditable = true;
			this.caPass.Visibility = false;
			this.caPass.InvisibleChar = '•';
			this.table3.Add (this.caPass);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table3 [this.caPass]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.LeftAttach = ((uint)(1));
			w2.RightAttach = ((uint)(2));
			w2.XPadding = ((uint)(10));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>CA Password</b>");
			this.label1.UseMarkup = true;
			this.table3.Add (this.label1);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table3 [this.label1]));
			w3.TopAttach = ((uint)(1));
			w3.BottomAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Generate New CRL</b>");
			this.label2.UseMarkup = true;
			this.table3.Add (this.label2);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table3 [this.label2]));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XPadding = ((uint)(10));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			w1.Add (this.table3);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(w1 [this.table3]));
			w5.Position = 0;
			w5.Expand = false;
			w5.Fill = false;
			// Internal child catoolgui.genCRL.ActionArea
			global::Gtk.HButtonBox w6 = this.ActionArea;
			w6.Name = "dialog1_ActionArea";
			w6.Spacing = 10;
			w6.BorderWidth = ((uint)(5));
			w6.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(2));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = global::Mono.Unix.Catalog.GetString ("Generate CRL");
			global::Gtk.Image w7 = new global::Gtk.Image ();
			w7.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-refresh", global::Gtk.IconSize.Menu);
			this.buttonCancel.Image = w7;
			this.AddActionWidget (this.buttonCancel, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w8 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w6 [this.buttonCancel]));
			w8.Expand = false;
			w8.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.cancelCRL = new global::Gtk.Button ();
			this.cancelCRL.CanFocus = true;
			this.cancelCRL.Name = "cancelCRL";
			this.cancelCRL.UseStock = true;
			this.cancelCRL.UseUnderline = true;
			this.cancelCRL.Label = "gtk-cancel";
			this.AddActionWidget (this.cancelCRL, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w9 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w6 [this.cancelCRL]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 272;
			this.DefaultHeight = 105;
			this.Show ();
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonGenerateClicked);
			this.cancelCRL.Clicked += new global::System.EventHandler (this.OnCancelCRLClicked);
		}
	}
}
