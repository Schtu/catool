
// This file has been generated by the GUI designer. Do not modify.
namespace compactCA
{
	public partial class revokeCert
	{
		private global::Gtk.Table table2;
		
		private global::Gtk.Label label3;
		
		private global::Gtk.ComboBox reasonBox;
		
		private global::Gtk.Entry revokeCAPass;
		
		private global::Gtk.Label revokeLabel;
		
		private global::Gtk.Button buttonCancel;
		
		private global::Gtk.Button buttonOk;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget catoolgui.revokeCert
			this.Name = "catoolgui.revokeCert";
			this.Title = global::Mono.Unix.Catalog.GetString ("Revoke Certificate");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			// Internal child catoolgui.revokeCert.VBox
			global::Gtk.VBox w1 = this.VBox;
			w1.Name = "dialog1_VBox";
			w1.BorderWidth = ((uint)(2));
			// Container child dialog1_VBox.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table (((uint)(2)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.label3 = new global::Gtk.Label ();
			this.label3.Name = "label3";
			this.label3.Xalign = 0F;
			this.label3.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>CA Password:</b>");
			this.label3.UseMarkup = true;
			this.table2.Add (this.label3);
			global::Gtk.Table.TableChild w2 = ((global::Gtk.Table.TableChild)(this.table2 [this.label3]));
			w2.TopAttach = ((uint)(1));
			w2.BottomAttach = ((uint)(2));
			w2.XPadding = ((uint)(10));
			w2.YPadding = ((uint)(5));
			w2.XOptions = ((global::Gtk.AttachOptions)(4));
			w2.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.reasonBox = global::Gtk.ComboBox.NewText ();
			this.reasonBox.AppendText (global::Mono.Unix.Catalog.GetString ("unspecified"));
			this.reasonBox.AppendText (global::Mono.Unix.Catalog.GetString ("keyCompromise"));
			this.reasonBox.AppendText (global::Mono.Unix.Catalog.GetString ("CACompromise"));
			this.reasonBox.AppendText (global::Mono.Unix.Catalog.GetString ("affiliationChanged"));
			this.reasonBox.AppendText (global::Mono.Unix.Catalog.GetString ("superseded"));
			this.reasonBox.AppendText (global::Mono.Unix.Catalog.GetString ("cessationOfOperation"));
			this.reasonBox.AppendText (global::Mono.Unix.Catalog.GetString ("certificateHold"));
			this.reasonBox.Name = "reasonBox";
			this.reasonBox.Active = 0;
			this.table2.Add (this.reasonBox);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table2 [this.reasonBox]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XPadding = ((uint)(10));
			w3.YPadding = ((uint)(5));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.revokeCAPass = new global::Gtk.Entry ();
			this.revokeCAPass.CanFocus = true;
			this.revokeCAPass.Name = "revokeCAPass";
			this.revokeCAPass.IsEditable = true;
			this.revokeCAPass.Visibility = false;
			this.revokeCAPass.InvisibleChar = '•';
			this.table2.Add (this.revokeCAPass);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table2 [this.revokeCAPass]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XPadding = ((uint)(10));
			w4.YPadding = ((uint)(5));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table2.Gtk.Table+TableChild
			this.revokeLabel = new global::Gtk.Label ();
			this.revokeLabel.Name = "revokeLabel";
			this.revokeLabel.Xalign = 0F;
			this.revokeLabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Choose Revoking Reason:</b>");
			this.revokeLabel.UseMarkup = true;
			this.table2.Add (this.revokeLabel);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table2 [this.revokeLabel]));
			w5.XPadding = ((uint)(10));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			w1.Add (this.table2);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(w1 [this.table2]));
			w6.Position = 0;
			w6.Expand = false;
			w6.Fill = false;
			// Internal child catoolgui.revokeCert.ActionArea
			global::Gtk.HButtonBox w7 = this.ActionArea;
			w7.Name = "dialog1_ActionArea";
			w7.Spacing = 10;
			w7.BorderWidth = ((uint)(5));
			w7.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonCancel = new global::Gtk.Button ();
			this.buttonCancel.CanDefault = true;
			this.buttonCancel.CanFocus = true;
			this.buttonCancel.Name = "buttonCancel";
			this.buttonCancel.UseStock = true;
			this.buttonCancel.UseUnderline = true;
			this.buttonCancel.Label = "gtk-cancel";
			this.AddActionWidget (this.buttonCancel, -6);
			global::Gtk.ButtonBox.ButtonBoxChild w8 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w7 [this.buttonCancel]));
			w8.Expand = false;
			w8.Fill = false;
			// Container child dialog1_ActionArea.Gtk.ButtonBox+ButtonBoxChild
			this.buttonOk = new global::Gtk.Button ();
			this.buttonOk.CanDefault = true;
			this.buttonOk.CanFocus = true;
			this.buttonOk.Name = "buttonOk";
			this.buttonOk.UseStock = true;
			this.buttonOk.UseUnderline = true;
			this.buttonOk.Label = "gtk-ok";
			this.AddActionWidget (this.buttonOk, -5);
			global::Gtk.ButtonBox.ButtonBoxChild w9 = ((global::Gtk.ButtonBox.ButtonBoxChild)(w7 [this.buttonOk]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 400;
			this.DefaultHeight = 129;
			this.Show ();
			this.buttonCancel.Clicked += new global::System.EventHandler (this.OnButtonCancelClicked);
			this.buttonOk.Clicked += new global::System.EventHandler (this.OnButtonOkClicked);
		}
	}
}
