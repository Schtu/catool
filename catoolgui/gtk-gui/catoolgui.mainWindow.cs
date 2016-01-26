
// This file has been generated by the GUI designer. Do not modify.
namespace catoolgui
{
	public partial class mainWindow
	{
		private global::Gtk.UIManager UIManager;
		
		private global::Gtk.Action CAAction;
		
		private global::Gtk.Action NewCAAction;
		
		private global::Gtk.Action DeleteCAAction;
		
		private global::Gtk.Action OpenCAAction;
		
		private global::Gtk.Action ExitAction;
		
		private global::Gtk.Action ProgramAction;
		
		private global::Gtk.Action ExitAction1;
		
		private global::Gtk.VBox vbox1;
		
		private global::Gtk.MenuBar menubar2;
		
		private global::Gtk.HButtonBox mainButtons;
		
		private global::Gtk.Button createCAButton;
		
		private global::Gtk.Button exportCA;
		
		private global::Gtk.Button publishCRL;
		
		private global::Gtk.Notebook mainNotebook;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow;
		
		private global::Gtk.TreeView caTreeView;
		
		private global::Gtk.Label caPage;
		
		private global::Gtk.VBox vbox3;
		
		private global::Gtk.Table table5;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow1;
		
		private global::Gtk.TreeView reqTreeView;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow4;
		
		private global::Gtk.TreeView reqInfoTreeView;
		
		private global::Gtk.HButtonBox hbuttonbox2;
		
		private global::Gtk.Button importButton;
		
		private global::Gtk.Button deleteimportedReq;
		
		private global::Gtk.Button createCertfromReqButton;
		
		private global::Gtk.Label reqPage;
		
		private global::Gtk.VBox vbox2;
		
		private global::Gtk.Table table2;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow2;
		
		private global::Gtk.TreeView certTreeView;
		
		private global::Gtk.ScrolledWindow GtkScrolledWindow3;
		
		private global::Gtk.TreeView infoCertTreeView;
		
		private global::Gtk.HButtonBox hbuttonbox4;
		
		private global::Gtk.Button createCert2;
		
		private global::Gtk.Button revokeCert;
		
		private global::Gtk.Button exportCert;
		
		private global::Gtk.Button delCert;
		
		private global::Gtk.Label cerPage;
		
		private global::Gtk.HBox hbox1;
		
		private global::Gtk.Label CAlabel;
		
		private global::Gtk.Label selCA;

		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget catoolgui.mainWindow
			this.UIManager = new global::Gtk.UIManager ();
			global::Gtk.ActionGroup w1 = new global::Gtk.ActionGroup ("Default");
			this.CAAction = new global::Gtk.Action ("CAAction", global::Mono.Unix.Catalog.GetString ("CA"), null, null);
			this.CAAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("File");
			w1.Add (this.CAAction, null);
			this.NewCAAction = new global::Gtk.Action ("NewCAAction", global::Mono.Unix.Catalog.GetString ("New CA"), null, null);
			this.NewCAAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("New CA");
			w1.Add (this.NewCAAction, null);
			this.DeleteCAAction = new global::Gtk.Action ("DeleteCAAction", global::Mono.Unix.Catalog.GetString ("Delete CA"), null, null);
			this.DeleteCAAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Delete CA");
			w1.Add (this.DeleteCAAction, null);
			this.OpenCAAction = new global::Gtk.Action ("OpenCAAction", global::Mono.Unix.Catalog.GetString ("Open CA"), null, null);
			this.OpenCAAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Open CA");
			w1.Add (this.OpenCAAction, null);
			this.ExitAction = new global::Gtk.Action ("ExitAction", global::Mono.Unix.Catalog.GetString ("Exit"), null, null);
			this.ExitAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Exit");
			w1.Add (this.ExitAction, null);
			this.ProgramAction = new global::Gtk.Action ("ProgramAction", global::Mono.Unix.Catalog.GetString ("Program"), null, null);
			this.ProgramAction.ShortLabel = global::Mono.Unix.Catalog.GetString ("Program");
			w1.Add (this.ProgramAction, null);
			this.ExitAction1 = new global::Gtk.Action ("ExitAction1", global::Mono.Unix.Catalog.GetString ("Exit"), null, null);
			this.ExitAction1.ShortLabel = global::Mono.Unix.Catalog.GetString ("Exit");
			w1.Add (this.ExitAction1, null);
			this.UIManager.InsertActionGroup (w1, 0);
			this.AddAccelGroup (this.UIManager.AccelGroup);
			this.Name = "catoolgui.mainWindow";
			this.Title = global::Mono.Unix.Catalog.GetString ("CA TOOL");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.Gravity = ((global::Gdk.Gravity)(5));
			// Container child catoolgui.mainWindow.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox ();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.UIManager.AddUiFromString ("<ui><menubar name='menubar2'><menu name='ProgramAction' action='ProgramAction'><menuitem name='ExitAction1' action='ExitAction1'/></menu><menu name='CAAction' action='CAAction'><menuitem name='NewCAAction' action='NewCAAction'/><menuitem name='DeleteCAAction' action='DeleteCAAction'/><menuitem name='OpenCAAction' action='OpenCAAction'/></menu></menubar></ui>");
			this.menubar2 = ((global::Gtk.MenuBar)(this.UIManager.GetWidget ("/menubar2")));
			this.menubar2.Name = "menubar2";
			this.vbox1.Add (this.menubar2);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.menubar2]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.mainButtons = new global::Gtk.HButtonBox ();
			this.mainButtons.Name = "mainButtons";
			this.mainButtons.BorderWidth = ((uint)(5));
			this.mainButtons.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(3));
			// Container child mainButtons.Gtk.ButtonBox+ButtonBoxChild
			this.createCAButton = new global::Gtk.Button ();
			this.createCAButton.CanFocus = true;
			this.createCAButton.Name = "createCAButton";
			this.createCAButton.UseUnderline = true;
			this.createCAButton.Label = global::Mono.Unix.Catalog.GetString ("New CA");
			global::Gtk.Image w3 = new global::Gtk.Image ();
			w3.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			this.createCAButton.Image = w3;
			this.mainButtons.Add (this.createCAButton);
			global::Gtk.ButtonBox.ButtonBoxChild w4 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.mainButtons [this.createCAButton]));
			w4.Expand = false;
			w4.Fill = false;
			// Container child mainButtons.Gtk.ButtonBox+ButtonBoxChild
			this.exportCA = new global::Gtk.Button ();
			this.exportCA.Sensitive = false;
			this.exportCA.CanFocus = true;
			this.exportCA.Name = "exportCA";
			this.exportCA.UseUnderline = true;
			this.exportCA.Label = global::Mono.Unix.Catalog.GetString ("Export CA Cert.");
			global::Gtk.Image w5 = new global::Gtk.Image ();
			w5.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-redo", global::Gtk.IconSize.Menu);
			this.exportCA.Image = w5;
			this.mainButtons.Add (this.exportCA);
			global::Gtk.ButtonBox.ButtonBoxChild w6 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.mainButtons [this.exportCA]));
			w6.Position = 1;
			w6.Expand = false;
			w6.Fill = false;
			// Container child mainButtons.Gtk.ButtonBox+ButtonBoxChild
			this.publishCRL = new global::Gtk.Button ();
			this.publishCRL.Sensitive = false;
			this.publishCRL.CanFocus = true;
			this.publishCRL.Name = "publishCRL";
			this.publishCRL.UseUnderline = true;
			this.publishCRL.Label = global::Mono.Unix.Catalog.GetString ("Publish CRL");
			global::Gtk.Image w7 = new global::Gtk.Image ();
			w7.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-redo", global::Gtk.IconSize.Menu);
			this.publishCRL.Image = w7;
			this.mainButtons.Add (this.publishCRL);
			global::Gtk.ButtonBox.ButtonBoxChild w8 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.mainButtons [this.publishCRL]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			this.vbox1.Add (this.mainButtons);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.mainButtons]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			w9.Padding = ((uint)(5));
			// Container child vbox1.Gtk.Box+BoxChild
			this.mainNotebook = new global::Gtk.Notebook ();
			this.mainNotebook.Sensitive = false;
			this.mainNotebook.Name = "mainNotebook";
			this.mainNotebook.CurrentPage = 1;
			this.mainNotebook.EnablePopup = true;
			// Container child mainNotebook.Gtk.Notebook+NotebookChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.caTreeView = new global::Gtk.TreeView ();
			this.caTreeView.CanFocus = true;
			this.caTreeView.Name = "caTreeView";
			this.caTreeView.EnableSearch = false;
			this.GtkScrolledWindow.Add (this.caTreeView);
			this.mainNotebook.Add (this.GtkScrolledWindow);
			// Notebook tab
			this.caPage = new global::Gtk.Label ();
			this.caPage.Name = "caPage";
			this.caPage.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>CA - Information</b>");
			this.caPage.UseMarkup = true;
			this.mainNotebook.SetTabLabel (this.GtkScrolledWindow, this.caPage);
			this.caPage.ShowAll ();
			// Container child mainNotebook.Gtk.Notebook+NotebookChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			this.vbox3.Spacing = 6;
			// Container child vbox3.Gtk.Box+BoxChild
			this.table5 = new global::Gtk.Table (((uint)(7)), ((uint)(2)), false);
			this.table5.Name = "table5";
			this.table5.RowSpacing = ((uint)(6));
			this.table5.ColumnSpacing = ((uint)(6));
			// Container child table5.Gtk.Table+TableChild
			this.GtkScrolledWindow1 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow1.Name = "GtkScrolledWindow1";
			this.GtkScrolledWindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			this.GtkScrolledWindow1.BorderWidth = ((uint)(5));
			// Container child GtkScrolledWindow1.Gtk.Container+ContainerChild
			this.reqTreeView = new global::Gtk.TreeView ();
			this.reqTreeView.CanFocus = true;
			this.reqTreeView.Name = "reqTreeView";
			this.GtkScrolledWindow1.Add (this.reqTreeView);
			this.table5.Add (this.GtkScrolledWindow1);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table5 [this.GtkScrolledWindow1]));
			w13.TopAttach = ((uint)(4));
			w13.BottomAttach = ((uint)(5));
			// Container child table5.Gtk.Table+TableChild
			this.GtkScrolledWindow4 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow4.Name = "GtkScrolledWindow4";
			this.GtkScrolledWindow4.ShadowType = ((global::Gtk.ShadowType)(1));
			this.GtkScrolledWindow4.BorderWidth = ((uint)(5));
			// Container child GtkScrolledWindow4.Gtk.Container+ContainerChild
			this.reqInfoTreeView = new global::Gtk.TreeView ();
			this.reqInfoTreeView.CanFocus = true;
			this.reqInfoTreeView.Name = "reqInfoTreeView";
			this.GtkScrolledWindow4.Add (this.reqInfoTreeView);
			this.table5.Add (this.GtkScrolledWindow4);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table5 [this.GtkScrolledWindow4]));
			w15.TopAttach = ((uint)(4));
			w15.BottomAttach = ((uint)(5));
			w15.LeftAttach = ((uint)(1));
			w15.RightAttach = ((uint)(2));
			this.vbox3.Add (this.table5);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.table5]));
			w16.Position = 0;
			// Container child vbox3.Gtk.Box+BoxChild
			this.hbuttonbox2 = new global::Gtk.HButtonBox ();
			this.hbuttonbox2.Name = "hbuttonbox2";
			this.hbuttonbox2.Spacing = 10;
			this.hbuttonbox2.BorderWidth = ((uint)(6));
			this.hbuttonbox2.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(3));
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.importButton = new global::Gtk.Button ();
			this.importButton.CanFocus = true;
			this.importButton.Name = "importButton";
			this.importButton.UseUnderline = true;
			this.importButton.Label = global::Mono.Unix.Catalog.GetString ("Import Request");
			global::Gtk.Image w17 = new global::Gtk.Image ();
			w17.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-undo", global::Gtk.IconSize.Menu);
			this.importButton.Image = w17;
			this.hbuttonbox2.Add (this.importButton);
			global::Gtk.ButtonBox.ButtonBoxChild w18 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.importButton]));
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.deleteimportedReq = new global::Gtk.Button ();
			this.deleteimportedReq.CanFocus = true;
			this.deleteimportedReq.Name = "deleteimportedReq";
			this.deleteimportedReq.UseUnderline = true;
			this.deleteimportedReq.Label = global::Mono.Unix.Catalog.GetString ("Delete Request");
			global::Gtk.Image w19 = new global::Gtk.Image ();
			w19.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-delete", global::Gtk.IconSize.Menu);
			this.deleteimportedReq.Image = w19;
			this.hbuttonbox2.Add (this.deleteimportedReq);
			global::Gtk.ButtonBox.ButtonBoxChild w20 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.deleteimportedReq]));
			w20.Position = 1;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbuttonbox2.Gtk.ButtonBox+ButtonBoxChild
			this.createCertfromReqButton = new global::Gtk.Button ();
			this.createCertfromReqButton.Sensitive = false;
			this.createCertfromReqButton.CanFocus = true;
			this.createCertfromReqButton.Name = "createCertfromReqButton";
			this.createCertfromReqButton.UseUnderline = true;
			this.createCertfromReqButton.Label = global::Mono.Unix.Catalog.GetString ("Create Certificate");
			global::Gtk.Image w21 = new global::Gtk.Image ();
			w21.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			this.createCertfromReqButton.Image = w21;
			this.hbuttonbox2.Add (this.createCertfromReqButton);
			global::Gtk.ButtonBox.ButtonBoxChild w22 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox2 [this.createCertfromReqButton]));
			w22.Position = 2;
			w22.Expand = false;
			w22.Fill = false;
			this.vbox3.Add (this.hbuttonbox2);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.hbuttonbox2]));
			w23.Position = 1;
			w23.Expand = false;
			this.mainNotebook.Add (this.vbox3);
			global::Gtk.Notebook.NotebookChild w24 = ((global::Gtk.Notebook.NotebookChild)(this.mainNotebook [this.vbox3]));
			w24.Position = 1;
			// Notebook tab
			this.reqPage = new global::Gtk.Label ();
			this.reqPage.Name = "reqPage";
			this.reqPage.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>CA  - Requests</b>");
			this.reqPage.UseMarkup = true;
			this.mainNotebook.SetTabLabel (this.vbox3, this.reqPage);
			this.reqPage.ShowAll ();
			// Container child mainNotebook.Gtk.Notebook+NotebookChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.table2 = new global::Gtk.Table (((uint)(1)), ((uint)(2)), false);
			this.table2.Name = "table2";
			this.table2.RowSpacing = ((uint)(6));
			this.table2.ColumnSpacing = ((uint)(6));
			// Container child table2.Gtk.Table+TableChild
			this.GtkScrolledWindow2 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow2.Name = "GtkScrolledWindow2";
			this.GtkScrolledWindow2.ShadowType = ((global::Gtk.ShadowType)(4));
			this.GtkScrolledWindow2.BorderWidth = ((uint)(5));
			// Container child GtkScrolledWindow2.Gtk.Container+ContainerChild
			this.certTreeView = new global::Gtk.TreeView ();
			this.certTreeView.CanFocus = true;
			this.certTreeView.Name = "certTreeView";
			this.GtkScrolledWindow2.Add (this.certTreeView);
			this.table2.Add (this.GtkScrolledWindow2);
			// Container child table2.Gtk.Table+TableChild
			this.GtkScrolledWindow3 = new global::Gtk.ScrolledWindow ();
			this.GtkScrolledWindow3.Name = "GtkScrolledWindow3";
			this.GtkScrolledWindow3.ShadowType = ((global::Gtk.ShadowType)(1));
			this.GtkScrolledWindow3.BorderWidth = ((uint)(5));
			// Container child GtkScrolledWindow3.Gtk.Container+ContainerChild
			this.infoCertTreeView = new global::Gtk.TreeView ();
			this.infoCertTreeView.CanFocus = true;
			this.infoCertTreeView.Name = "infoCertTreeView";
			this.GtkScrolledWindow3.Add (this.infoCertTreeView);
			this.table2.Add (this.GtkScrolledWindow3);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table2 [this.GtkScrolledWindow3]));
			w28.LeftAttach = ((uint)(1));
			w28.RightAttach = ((uint)(2));
			this.vbox2.Add (this.table2);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.table2]));
			w29.Position = 0;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbuttonbox4 = new global::Gtk.HButtonBox ();
			this.hbuttonbox4.Name = "hbuttonbox4";
			this.hbuttonbox4.Spacing = 10;
			this.hbuttonbox4.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(3));
			// Container child hbuttonbox4.Gtk.ButtonBox+ButtonBoxChild
			this.createCert2 = new global::Gtk.Button ();
			this.createCert2.CanFocus = true;
			this.createCert2.Name = "createCert2";
			this.createCert2.UseUnderline = true;
			this.createCert2.Label = global::Mono.Unix.Catalog.GetString ("New Cert");
			global::Gtk.Image w30 = new global::Gtk.Image ();
			w30.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-add", global::Gtk.IconSize.Menu);
			this.createCert2.Image = w30;
			this.hbuttonbox4.Add (this.createCert2);
			global::Gtk.ButtonBox.ButtonBoxChild w31 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox4 [this.createCert2]));
			w31.Expand = false;
			w31.Fill = false;
			// Container child hbuttonbox4.Gtk.ButtonBox+ButtonBoxChild
			this.revokeCert = new global::Gtk.Button ();
			this.revokeCert.Sensitive = false;
			this.revokeCert.CanFocus = true;
			this.revokeCert.Name = "revokeCert";
			this.revokeCert.UseUnderline = true;
			this.revokeCert.Label = global::Mono.Unix.Catalog.GetString ("Revoke Cert");
			global::Gtk.Image w32 = new global::Gtk.Image ();
			w32.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-undo", global::Gtk.IconSize.Menu);
			this.revokeCert.Image = w32;
			this.hbuttonbox4.Add (this.revokeCert);
			global::Gtk.ButtonBox.ButtonBoxChild w33 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox4 [this.revokeCert]));
			w33.Position = 1;
			w33.Expand = false;
			w33.Fill = false;
			// Container child hbuttonbox4.Gtk.ButtonBox+ButtonBoxChild
			this.exportCert = new global::Gtk.Button ();
			this.exportCert.Sensitive = false;
			this.exportCert.CanFocus = true;
			this.exportCert.Name = "exportCert";
			this.exportCert.UseUnderline = true;
			this.exportCert.Label = global::Mono.Unix.Catalog.GetString ("Export Cert");
			global::Gtk.Image w34 = new global::Gtk.Image ();
			w34.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-redo", global::Gtk.IconSize.Menu);
			this.exportCert.Image = w34;
			this.hbuttonbox4.Add (this.exportCert);
			global::Gtk.ButtonBox.ButtonBoxChild w35 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox4 [this.exportCert]));
			w35.Position = 2;
			w35.Expand = false;
			w35.Fill = false;
			// Container child hbuttonbox4.Gtk.ButtonBox+ButtonBoxChild
			this.delCert = new global::Gtk.Button ();
			this.delCert.Sensitive = false;
			this.delCert.CanFocus = true;
			this.delCert.Name = "delCert";
			this.delCert.UseUnderline = true;
			this.delCert.Label = global::Mono.Unix.Catalog.GetString ("Delete Cert");
			global::Gtk.Image w36 = new global::Gtk.Image ();
			w36.Pixbuf = global::Stetic.IconLoader.LoadIcon (this, "gtk-delete", global::Gtk.IconSize.Menu);
			this.delCert.Image = w36;
			this.hbuttonbox4.Add (this.delCert);
			global::Gtk.ButtonBox.ButtonBoxChild w37 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox4 [this.delCert]));
			w37.Position = 3;
			w37.Expand = false;
			w37.Fill = false;
			this.vbox2.Add (this.hbuttonbox4);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.hbuttonbox4]));
			w38.Position = 1;
			w38.Fill = false;
			this.mainNotebook.Add (this.vbox2);
			global::Gtk.Notebook.NotebookChild w39 = ((global::Gtk.Notebook.NotebookChild)(this.mainNotebook [this.vbox2]));
			w39.Position = 2;
			// Notebook tab
			this.cerPage = new global::Gtk.Label ();
			this.cerPage.Name = "cerPage";
			this.cerPage.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>CA - Certificates</b>");
			this.cerPage.UseMarkup = true;
			this.mainNotebook.SetTabLabel (this.vbox2, this.cerPage);
			this.cerPage.ShowAll ();
			this.vbox1.Add (this.mainNotebook);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.mainNotebook]));
			w40.Position = 2;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox ();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.CAlabel = new global::Gtk.Label ();
			this.CAlabel.Name = "CAlabel";
			this.CAlabel.Xpad = 10;
			this.CAlabel.Ypad = 5;
			this.CAlabel.LabelProp = global::Mono.Unix.Catalog.GetString ("<b>Selected CA:</b>");
			this.CAlabel.UseMarkup = true;
			this.hbox1.Add (this.CAlabel);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.CAlabel]));
			w41.Position = 0;
			w41.Expand = false;
			w41.Fill = false;
			w41.Padding = ((uint)(5));
			// Container child hbox1.Gtk.Box+BoxChild
			this.selCA = new global::Gtk.Label ();
			this.selCA.Name = "selCA";
			this.selCA.Xpad = 10;
			this.selCA.Ypad = 5;
			this.selCA.UseMarkup = true;
			this.hbox1.Add (this.selCA);
			global::Gtk.Box.BoxChild w42 = ((global::Gtk.Box.BoxChild)(this.hbox1 [this.selCA]));
			w42.Position = 1;
			w42.Expand = false;
			w42.Fill = false;
			this.vbox1.Add (this.hbox1);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.vbox1 [this.hbox1]));
			w43.Position = 3;
			w43.Expand = false;
			w43.Fill = false;
			this.Add (this.vbox1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.DefaultWidth = 690;
			this.DefaultHeight = 392;
			this.caPage.Hide ();
			this.reqPage.Hide ();
			this.cerPage.Hide ();
			this.CAlabel.Hide ();
			this.Show ();
			this.NewCAAction.Activated += new global::System.EventHandler (this.OnNewCAActionActivated);
			this.DeleteCAAction.Activated += new global::System.EventHandler (this.OnDeleteCAActionActivated);
			this.OpenCAAction.Activated += new global::System.EventHandler (this.OnOpenCAActionActivated);
			this.ExitAction.Activated += new global::System.EventHandler (this.OnExitActionActivated);
			this.ExitAction1.Activated += new global::System.EventHandler (this.OnExitActionActivated);
			this.createCAButton.Clicked += new global::System.EventHandler (this.OnCreateCAButtonClicked);
			this.exportCA.Clicked += new global::System.EventHandler (this.OnExportCAClicked);
			this.publishCRL.Clicked += new global::System.EventHandler (this.OnPublishCRLClicked);
			this.reqTreeView.CursorChanged += new global::System.EventHandler (this.OnReqTreeViewCursorChanged);
			this.importButton.Clicked += new global::System.EventHandler (this.OnImportButtonClicked);
			this.deleteimportedReq.Clicked += new global::System.EventHandler (this.OnDeleteimportedReqClicked);
			this.createCertfromReqButton.Clicked += new global::System.EventHandler (this.OnCreateCertfromReqButtonClicked);
			this.certTreeView.CursorChanged += new global::System.EventHandler (this.OnCertTreeViewCursorChanged);
			this.createCert2.Clicked += new global::System.EventHandler (this.OnCreateCert2Clicked);
			this.revokeCert.Clicked += new global::System.EventHandler (this.OnRevokeCertClicked);
			this.exportCert.Clicked += new global::System.EventHandler (this.OnExportCertClicked);
			this.delCert.Clicked += new global::System.EventHandler (this.OnDelCertClicked);
		}
	}
}