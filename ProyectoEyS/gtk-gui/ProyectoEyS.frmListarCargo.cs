
// This file has been generated by the GUI designer. Do not modify.
namespace ProyectoEyS
{
	public partial class frmListarCargo
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Label lbListCargo;

		private global::Gtk.HBox hbox1;

		private global::Gtk.VSeparator vseparator3;

		private global::Gtk.Table table1;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TextView lbDesc;

		private global::Gtk.Label lbDept;

		private global::Gtk.Label lbDeptTxt;

		private global::Gtk.Label lbDesCar;

		private global::Gtk.Label lbID;

		private global::Gtk.Label lbIDCar;

		private global::Gtk.Label lbNombre;

		private global::Gtk.Label lbNomCar;

		private global::Gtk.VSeparator vseparator2;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.VBox scrolled;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Label label4;

		private global::Gtk.Entry txbBuscar;

		private global::Gtk.ScrolledWindow GTKscrolled;

		private global::Gtk.TreeView trvwCargo;

		private global::Gtk.HBox hbox2;

		private global::Gtk.HBox hbox4;

		private global::Gtk.VSeparator vseparator5;

		private global::Gtk.HBox hbox5;

		private global::Gtk.HBox hbox7;

		private global::Gtk.ComboBox cbxEListarCar;

		private global::Gtk.VSeparator vseparator6;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Button btnAntCar;

		private global::Gtk.Label lbCountCar;

		private global::Gtk.Button btnSigCar;

		private global::Gtk.VSeparator vseparator4;

		private global::Gtk.HButtonBox hbuttonbox6;

		private global::Gtk.Button buttonFiltrar;

		private global::Gtk.Button buttonAdmin;

		private global::Gtk.Button buttonClose;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProyectoEyS.frmListarCargo
			this.Name = "ProyectoEyS.frmListarCargo";
			this.Title = global::Mono.Unix.Catalog.GetString("frmListarCargo");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			// Container child ProyectoEyS.frmListarCargo.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.lbListCargo = new global::Gtk.Label();
			this.lbListCargo.HeightRequest = 35;
			this.lbListCargo.Name = "lbListCargo";
			this.lbListCargo.Xalign = 0.03F;
			this.lbListCargo.LabelProp = global::Mono.Unix.Catalog.GetString("Listar cargo");
			this.vbox1.Add(this.lbListCargo);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.lbListCargo]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox1 = new global::Gtk.HBox();
			this.hbox1.Name = "hbox1";
			this.hbox1.Spacing = 6;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vseparator3 = new global::Gtk.VSeparator();
			this.vseparator3.WidthRequest = 18;
			this.vseparator3.Name = "vseparator3";
			this.hbox1.Add(this.vseparator3);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vseparator3]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.table1 = new global::Gtk.Table(((uint)(4)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.WidthRequest = 300;
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.lbDesc = new global::Gtk.TextView();
			this.lbDesc.Sensitive = false;
			this.lbDesc.CanFocus = true;
			this.lbDesc.Name = "lbDesc";
			this.lbDesc.WrapMode = ((global::Gtk.WrapMode)(3));
			this.GtkScrolledWindow.Add(this.lbDesc);
			this.table1.Add(this.GtkScrolledWindow);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.GtkScrolledWindow]));
			w4.TopAttach = ((uint)(3));
			w4.BottomAttach = ((uint)(4));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbDept = new global::Gtk.Label();
			this.lbDept.Name = "lbDept";
			this.lbDept.Xalign = 0F;
			this.lbDept.LabelProp = global::Mono.Unix.Catalog.GetString("Texto de ejemplo");
			this.table1.Add(this.lbDept);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.lbDept]));
			w5.TopAttach = ((uint)(2));
			w5.BottomAttach = ((uint)(3));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbDeptTxt = new global::Gtk.Label();
			this.lbDeptTxt.HeightRequest = 20;
			this.lbDeptTxt.Name = "lbDeptTxt";
			this.lbDeptTxt.Xalign = 0F;
			this.lbDeptTxt.LabelProp = global::Mono.Unix.Catalog.GetString("Departamento:");
			this.table1.Add(this.lbDeptTxt);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.lbDeptTxt]));
			w6.TopAttach = ((uint)(2));
			w6.BottomAttach = ((uint)(3));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbDesCar = new global::Gtk.Label();
			this.lbDesCar.HeightRequest = 30;
			this.lbDesCar.Name = "lbDesCar";
			this.lbDesCar.Xalign = 0F;
			this.lbDesCar.Yalign = 0.2F;
			this.lbDesCar.LabelProp = global::Mono.Unix.Catalog.GetString("Descripci??n:");
			this.table1.Add(this.lbDesCar);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.lbDesCar]));
			w7.TopAttach = ((uint)(3));
			w7.BottomAttach = ((uint)(4));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbID = new global::Gtk.Label();
			this.lbID.Name = "lbID";
			this.lbID.Xalign = 0F;
			this.lbID.LabelProp = global::Mono.Unix.Catalog.GetString("Texto de ejemplo");
			this.table1.Add(this.lbID);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.lbID]));
			w8.LeftAttach = ((uint)(1));
			w8.RightAttach = ((uint)(2));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbIDCar = new global::Gtk.Label();
			this.lbIDCar.WidthRequest = 139;
			this.lbIDCar.HeightRequest = 20;
			this.lbIDCar.Name = "lbIDCar";
			this.lbIDCar.Xalign = 0F;
			this.lbIDCar.LabelProp = global::Mono.Unix.Catalog.GetString("ID:");
			this.table1.Add(this.lbIDCar);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.lbIDCar]));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbNombre = new global::Gtk.Label();
			this.lbNombre.Name = "lbNombre";
			this.lbNombre.Xalign = 0F;
			this.lbNombre.LabelProp = global::Mono.Unix.Catalog.GetString("Texto de ejemplo");
			this.table1.Add(this.lbNombre);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.lbNombre]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.LeftAttach = ((uint)(1));
			w10.RightAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbNomCar = new global::Gtk.Label();
			this.lbNomCar.HeightRequest = 20;
			this.lbNomCar.Name = "lbNomCar";
			this.lbNomCar.Xalign = 0F;
			this.lbNomCar.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre:");
			this.table1.Add(this.lbNomCar);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.lbNomCar]));
			w11.TopAttach = ((uint)(1));
			w11.BottomAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add(this.table1);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.table1]));
			w12.Position = 1;
			w12.Expand = false;
			w12.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vseparator2 = new global::Gtk.VSeparator();
			this.vseparator2.WidthRequest = 18;
			this.vseparator2.Name = "vseparator2";
			this.hbox1.Add(this.vseparator2);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vseparator2]));
			w13.Position = 2;
			w13.Expand = false;
			w13.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w14.Position = 1;
			w14.Expand = false;
			w14.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.HeightRequest = 19;
			this.hseparator1.Name = "hseparator1";
			this.vbox1.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hseparator1]));
			w15.Position = 2;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.scrolled = new global::Gtk.VBox();
			this.scrolled.Name = "scrolled";
			this.scrolled.Spacing = 6;
			// Container child scrolled.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.label4 = new global::Gtk.Label();
			this.label4.Name = "label4";
			this.label4.LabelProp = global::Mono.Unix.Catalog.GetString("Buscar:");
			this.hbox8.Add(this.label4);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.label4]));
			w16.Position = 0;
			w16.Expand = false;
			w16.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.txbBuscar = new global::Gtk.Entry();
			this.txbBuscar.CanFocus = true;
			this.txbBuscar.Name = "txbBuscar";
			this.txbBuscar.IsEditable = true;
			this.txbBuscar.InvisibleChar = '???';
			this.hbox8.Add(this.txbBuscar);
			global::Gtk.Box.BoxChild w17 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.txbBuscar]));
			w17.Position = 1;
			this.scrolled.Add(this.hbox8);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.scrolled[this.hbox8]));
			w18.Position = 0;
			w18.Expand = false;
			w18.Fill = false;
			// Container child scrolled.Gtk.Box+BoxChild
			this.GTKscrolled = new global::Gtk.ScrolledWindow();
			this.GTKscrolled.Name = "GTKscrolled";
			this.GTKscrolled.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GTKscrolled.Gtk.Container+ContainerChild
			this.trvwCargo = new global::Gtk.TreeView();
			this.trvwCargo.HeightRequest = 150;
			this.trvwCargo.CanFocus = true;
			this.trvwCargo.Name = "trvwCargo";
			this.GTKscrolled.Add(this.trvwCargo);
			this.scrolled.Add(this.GTKscrolled);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.scrolled[this.GTKscrolled]));
			w20.Position = 1;
			this.vbox1.Add(this.scrolled);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.scrolled]));
			w21.Position = 3;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.HeightRequest = 35;
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vseparator5 = new global::Gtk.VSeparator();
			this.vseparator5.WidthRequest = 18;
			this.vseparator5.Name = "vseparator5";
			this.hbox4.Add(this.vseparator5);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vseparator5]));
			w22.Position = 0;
			w22.Expand = false;
			w22.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.cbxEListarCar = global::Gtk.ComboBox.NewText();
			this.cbxEListarCar.WidthRequest = 210;
			this.cbxEListarCar.Name = "cbxEListarCar";
			this.hbox7.Add(this.cbxEListarCar);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.cbxEListarCar]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.vseparator6 = new global::Gtk.VSeparator();
			this.vseparator6.WidthRequest = 18;
			this.vseparator6.Name = "vseparator6";
			this.hbox7.Add(this.vseparator6);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.vseparator6]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			this.hbox5.Add(this.hbox7);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.hbox7]));
			w25.Position = 0;
			w25.Expand = false;
			w25.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.btnAntCar = new global::Gtk.Button();
			this.btnAntCar.WidthRequest = 48;
			this.btnAntCar.HeightRequest = 48;
			this.btnAntCar.CanFocus = true;
			this.btnAntCar.Name = "btnAntCar";
			this.btnAntCar.UseUnderline = true;
			this.btnAntCar.Label = global::Mono.Unix.Catalog.GetString("<");
			this.hbox6.Add(this.btnAntCar);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.btnAntCar]));
			w26.Position = 0;
			w26.Expand = false;
			w26.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.lbCountCar = new global::Gtk.Label();
			this.lbCountCar.WidthRequest = 98;
			this.lbCountCar.Name = "lbCountCar";
			this.lbCountCar.LabelProp = global::Mono.Unix.Catalog.GetString("999/999");
			this.hbox6.Add(this.lbCountCar);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.lbCountCar]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.btnSigCar = new global::Gtk.Button();
			this.btnSigCar.WidthRequest = 48;
			this.btnSigCar.HeightRequest = 48;
			this.btnSigCar.CanFocus = true;
			this.btnSigCar.Name = "btnSigCar";
			this.btnSigCar.UseUnderline = true;
			this.btnSigCar.Label = global::Mono.Unix.Catalog.GetString(">");
			this.hbox6.Add(this.btnSigCar);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.btnSigCar]));
			w28.Position = 2;
			w28.Expand = false;
			w28.Fill = false;
			this.hbox5.Add(this.hbox6);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.hbox6]));
			w29.Position = 1;
			w29.Expand = false;
			w29.Fill = false;
			this.hbox4.Add(this.hbox5);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.hbox5]));
			w30.Position = 1;
			w30.Expand = false;
			w30.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vseparator4 = new global::Gtk.VSeparator();
			this.vseparator4.WidthRequest = 18;
			this.vseparator4.Name = "vseparator4";
			this.hbox4.Add(this.vseparator4);
			global::Gtk.Box.BoxChild w31 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vseparator4]));
			w31.Position = 2;
			w31.Expand = false;
			w31.Fill = false;
			this.hbox2.Add(this.hbox4);
			global::Gtk.Box.BoxChild w32 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.hbox4]));
			w32.Position = 0;
			w32.Expand = false;
			w32.Fill = false;
			this.vbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w33 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w33.Position = 4;
			w33.Expand = false;
			w33.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbuttonbox6 = new global::Gtk.HButtonBox();
			this.hbuttonbox6.HeightRequest = 50;
			this.hbuttonbox6.Name = "hbuttonbox6";
			this.hbuttonbox6.Spacing = 4;
			this.hbuttonbox6.BorderWidth = ((uint)(10));
			this.hbuttonbox6.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.buttonFiltrar = new global::Gtk.Button();
			this.buttonFiltrar.CanFocus = true;
			this.buttonFiltrar.Name = "buttonFiltrar";
			this.buttonFiltrar.UseUnderline = true;
			this.buttonFiltrar.Label = global::Mono.Unix.Catalog.GetString("Filtrar");
			this.hbuttonbox6.Add(this.buttonFiltrar);
			global::Gtk.ButtonBox.ButtonBoxChild w34 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.buttonFiltrar]));
			w34.Expand = false;
			w34.Fill = false;
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.buttonAdmin = new global::Gtk.Button();
			this.buttonAdmin.WidthRequest = 90;
			this.buttonAdmin.HeightRequest = 30;
			this.buttonAdmin.CanFocus = true;
			this.buttonAdmin.Name = "buttonAdmin";
			this.buttonAdmin.UseUnderline = true;
			this.buttonAdmin.Label = global::Mono.Unix.Catalog.GetString("Administrar");
			this.hbuttonbox6.Add(this.buttonAdmin);
			global::Gtk.ButtonBox.ButtonBoxChild w35 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.buttonAdmin]));
			w35.Position = 1;
			w35.Expand = false;
			w35.Fill = false;
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.buttonClose = new global::Gtk.Button();
			this.buttonClose.CanFocus = true;
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.UseUnderline = true;
			this.buttonClose.Label = global::Mono.Unix.Catalog.GetString("Cerrar");
			this.hbuttonbox6.Add(this.buttonClose);
			global::Gtk.ButtonBox.ButtonBoxChild w36 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.buttonClose]));
			w36.Position = 2;
			w36.Expand = false;
			w36.Fill = false;
			this.vbox1.Add(this.hbuttonbox6);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbuttonbox6]));
			w37.Position = 5;
			w37.Expand = false;
			w37.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 494;
			this.DefaultHeight = 515;
			this.Show();
			this.txbBuscar.Changed += new global::System.EventHandler(this.OnTxbBuscarChanged);
			this.cbxEListarCar.Changed += new global::System.EventHandler(this.OnCbxEListarCarChanged);
			this.btnAntCar.Clicked += new global::System.EventHandler(this.OnBtnAntCarClicked);
			this.btnSigCar.Clicked += new global::System.EventHandler(this.OnBtnSigCarClicked);
			this.buttonFiltrar.Clicked += new global::System.EventHandler(this.OnButtonFiltrarClicked);
			this.buttonAdmin.Clicked += new global::System.EventHandler(this.OnButtonAdminClicked);
			this.buttonClose.Clicked += new global::System.EventHandler(this.OnButtonCloseClicked);
		}
	}
}
