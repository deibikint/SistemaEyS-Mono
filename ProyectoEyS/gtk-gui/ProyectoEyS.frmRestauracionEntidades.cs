
// This file has been generated by the GUI designer. Do not modify.
namespace ProyectoEyS
{
	public partial class frmRestauracionEntidades
	{
		private global::Gtk.VBox vbox2;

		private global::Gtk.Label labelTitulo;

		private global::Gtk.HBox hbox11;

		private global::Gtk.VSeparator vseparator3;

		private global::Gtk.Table table3;

		private global::Gtk.Label EntryID;

		private global::Gtk.Label EntryUser;

		private global::Gtk.Label label4;

		private global::Gtk.Label label5;

		private global::Gtk.VSeparator vseparator2;

		private global::Gtk.HBox hbox5;

		private global::Gtk.VSeparator vseparator6;

		private global::Gtk.HBox hbox6;

		private global::Gtk.HBox hbox8;

		private global::Gtk.ComboBoxEntry cbxDyn;

		private global::Gtk.VSeparator vseparator7;

		private global::Gtk.HBox hbox9;

		private global::Gtk.Button btnAntUsr;

		private global::Gtk.Label lbCount;

		private global::Gtk.Button btnSigUsr;

		private global::Gtk.VSeparator vseparator8;

		private global::Gtk.HButtonBox hbuttonbox6;

		private global::Gtk.Button buttonRestaurar;

		private global::Gtk.Button buttonClose;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProyectoEyS.frmRestauracionEntidades
			this.Name = "ProyectoEyS.frmRestauracionEntidades";
			this.Title = global::Mono.Unix.Catalog.GetString("frmRestauracionEntidades");
			this.WindowPosition = ((global::Gtk.WindowPosition)(1));
			this.Resizable = false;
			// Container child ProyectoEyS.frmRestauracionEntidades.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox();
			this.vbox2.Name = "vbox2";
			this.vbox2.Spacing = 6;
			// Container child vbox2.Gtk.Box+BoxChild
			this.labelTitulo = new global::Gtk.Label();
			this.labelTitulo.HeightRequest = 35;
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Xalign = 0.03F;
			this.labelTitulo.LabelProp = global::Mono.Unix.Catalog.GetString("Seguridad: Restauración de entidades");
			this.vbox2.Add(this.labelTitulo);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.labelTitulo]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox11 = new global::Gtk.HBox();
			this.hbox11.Name = "hbox11";
			this.hbox11.Spacing = 6;
			// Container child hbox11.Gtk.Box+BoxChild
			this.vseparator3 = new global::Gtk.VSeparator();
			this.vseparator3.WidthRequest = 18;
			this.vseparator3.Name = "vseparator3";
			this.hbox11.Add(this.vseparator3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.vseparator3]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.table3 = new global::Gtk.Table(((uint)(2)), ((uint)(2)), false);
			this.table3.Name = "table3";
			this.table3.RowSpacing = ((uint)(6));
			this.table3.ColumnSpacing = ((uint)(6));
			// Container child table3.Gtk.Table+TableChild
			this.EntryID = new global::Gtk.Label();
			this.EntryID.WidthRequest = 267;
			this.EntryID.HeightRequest = 30;
			this.EntryID.Name = "EntryID";
			this.EntryID.Xalign = 0F;
			this.EntryID.LabelProp = global::Mono.Unix.Catalog.GetString("X");
			this.table3.Add(this.EntryID);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table3[this.EntryID]));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.EntryUser = new global::Gtk.Label();
			this.EntryUser.WidthRequest = 175;
			this.EntryUser.HeightRequest = 30;
			this.EntryUser.Name = "EntryUser";
			this.EntryUser.Xalign = 0F;
			this.EntryUser.LabelProp = global::Mono.Unix.Catalog.GetString("Texto de ejemplo");
			this.table3.Add(this.EntryUser);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table3[this.EntryUser]));
			w4.TopAttach = ((uint)(1));
			w4.BottomAttach = ((uint)(2));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label4 = new global::Gtk.Label();
			this.label4.WidthRequest = 175;
			this.label4.HeightRequest = 30;
			this.label4.Name = "label4";
			this.label4.Xalign = 0F;
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("ID:");
			this.table3.Add(this.label4);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table3[this.label4]));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table3.Gtk.Table+TableChild
			this.label5 = new global::Gtk.Label();
			this.label5.WidthRequest = 175;
			this.label5.HeightRequest = 30;
			this.label5.Name = "label5";
			this.label5.Xalign = 0F;
			this.label5.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre de usuario:");
			this.table3.Add(this.label5);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table3[this.label5]));
			w6.TopAttach = ((uint)(1));
			w6.BottomAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox11.Add(this.table3);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.table3]));
			w7.Position = 1;
			w7.Expand = false;
			w7.Fill = false;
			// Container child hbox11.Gtk.Box+BoxChild
			this.vseparator2 = new global::Gtk.VSeparator();
			this.vseparator2.WidthRequest = 18;
			this.vseparator2.Name = "vseparator2";
			this.hbox11.Add(this.vseparator2);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.hbox11[this.vseparator2]));
			w8.Position = 2;
			w8.Expand = false;
			w8.Fill = false;
			this.vbox2.Add(this.hbox11);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox11]));
			w9.Position = 1;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.HeightRequest = 35;
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.vseparator6 = new global::Gtk.VSeparator();
			this.vseparator6.WidthRequest = 18;
			this.vseparator6.Name = "vseparator6";
			this.hbox5.Add(this.vseparator6);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.vseparator6]));
			w10.Position = 0;
			w10.Expand = false;
			w10.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.cbxDyn = global::Gtk.ComboBoxEntry.NewText();
			this.cbxDyn.WidthRequest = 211;
			this.cbxDyn.Name = "cbxDyn";
			this.hbox8.Add(this.cbxDyn);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.cbxDyn]));
			w11.Position = 0;
			w11.Expand = false;
			w11.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.vseparator7 = new global::Gtk.VSeparator();
			this.vseparator7.WidthRequest = 18;
			this.vseparator7.Name = "vseparator7";
			this.hbox8.Add(this.vseparator7);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.vseparator7]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			this.hbox6.Add(this.hbox8);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.hbox8]));
			w13.Position = 0;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.btnAntUsr = new global::Gtk.Button();
			this.btnAntUsr.WidthRequest = 48;
			this.btnAntUsr.HeightRequest = 48;
			this.btnAntUsr.CanFocus = true;
			this.btnAntUsr.Name = "btnAntUsr";
			this.btnAntUsr.UseUnderline = true;
			this.btnAntUsr.Label = global::Mono.Unix.Catalog.GetString("<");
			this.hbox9.Add(this.btnAntUsr);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.btnAntUsr]));
			w14.Position = 0;
			w14.Expand = false;
			w14.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.lbCount = new global::Gtk.Label();
			this.lbCount.WidthRequest = 98;
			this.lbCount.Name = "lbCount";
			this.lbCount.LabelProp = global::Mono.Unix.Catalog.GetString("999/999");
			this.hbox9.Add(this.lbCount);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.lbCount]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child hbox9.Gtk.Box+BoxChild
			this.btnSigUsr = new global::Gtk.Button();
			this.btnSigUsr.WidthRequest = 48;
			this.btnSigUsr.HeightRequest = 48;
			this.btnSigUsr.CanFocus = true;
			this.btnSigUsr.Name = "btnSigUsr";
			this.btnSigUsr.UseUnderline = true;
			this.btnSigUsr.Label = global::Mono.Unix.Catalog.GetString(">");
			this.hbox9.Add(this.btnSigUsr);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.btnSigUsr]));
			w16.Position = 2;
			w16.Expand = false;
			w16.Fill = false;
			this.hbox6.Add(this.hbox9);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.hbox9]));
			w17.Position = 1;
			w17.Expand = false;
			w17.Fill = false;
			this.hbox5.Add(this.hbox6);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.hbox6]));
			w18.Position = 1;
			w18.Expand = false;
			w18.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.vseparator8 = new global::Gtk.VSeparator();
			this.vseparator8.WidthRequest = 18;
			this.vseparator8.Name = "vseparator8";
			this.hbox5.Add(this.vseparator8);
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.vseparator8]));
			w19.Position = 2;
			w19.Expand = false;
			w19.Fill = false;
			this.vbox2.Add(this.hbox5);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbox5]));
			w20.Position = 2;
			w20.Expand = false;
			w20.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.hbuttonbox6 = new global::Gtk.HButtonBox();
			this.hbuttonbox6.HeightRequest = 50;
			this.hbuttonbox6.Name = "hbuttonbox6";
			this.hbuttonbox6.Spacing = 4;
			this.hbuttonbox6.BorderWidth = ((uint)(10));
			this.hbuttonbox6.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.buttonRestaurar = new global::Gtk.Button();
			this.buttonRestaurar.CanFocus = true;
			this.buttonRestaurar.Name = "buttonRestaurar";
			this.buttonRestaurar.UseUnderline = true;
			this.buttonRestaurar.Label = global::Mono.Unix.Catalog.GetString("Restaurar");
			this.hbuttonbox6.Add(this.buttonRestaurar);
			global::Gtk.ButtonBox.ButtonBoxChild w21 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.buttonRestaurar]));
			w21.Expand = false;
			w21.Fill = false;
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.buttonClose = new global::Gtk.Button();
			this.buttonClose.CanFocus = true;
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.UseUnderline = true;
			this.buttonClose.Label = global::Mono.Unix.Catalog.GetString("Cerrar");
			this.hbuttonbox6.Add(this.buttonClose);
			global::Gtk.ButtonBox.ButtonBoxChild w22 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.buttonClose]));
			w22.Position = 1;
			w22.Expand = false;
			w22.Fill = false;
			this.vbox2.Add(this.hbuttonbox6);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.vbox2[this.hbuttonbox6]));
			w23.Position = 3;
			w23.Expand = false;
			w23.Fill = false;
			this.Add(this.vbox2);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 496;
			this.DefaultHeight = 204;
			this.Show();
			this.cbxDyn.Changed += new global::System.EventHandler(this.OnCbxDynChanged);
			this.btnAntUsr.Clicked += new global::System.EventHandler(this.OnBtnAntUsrClicked);
			this.btnSigUsr.Clicked += new global::System.EventHandler(this.OnBtnSigUsrClicked);
			this.buttonRestaurar.Clicked += new global::System.EventHandler(this.OnButtonRestaurarClicked);
			this.buttonClose.Clicked += new global::System.EventHandler(this.OnButtonCloseClicked);
		}
	}
}
