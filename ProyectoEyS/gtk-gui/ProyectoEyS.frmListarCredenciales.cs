
// This file has been generated by the GUI designer. Do not modify.
namespace ProyectoEyS
{
	public partial class frmListarCredenciales
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Label labelTitulo;

		private global::Gtk.HBox hbox1;

		private global::Gtk.VSeparator vseparator3;

		private global::Gtk.Table table1;

		private global::Gtk.Label lbConCre;

		private global::Gtk.Label lbContraseña;

		private global::Gtk.Label lbEmpCre;

		private global::Gtk.Label lbEmpleado;

		private global::Gtk.Label lbID;

		private global::Gtk.Label lbIDCre;

		private global::Gtk.Label lbNombre;

		private global::Gtk.Label lbNomCre;

		private global::Gtk.Label lbRol;

		private global::Gtk.Label lbRolCre;

		private global::Gtk.VSeparator vseparator2;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.ScrolledWindow scrolled;

		private global::Gtk.TreeView trvwCredenciales;

		private global::Gtk.HBox hbox2;

		private global::Gtk.HBox hbox4;

		private global::Gtk.VSeparator vseparator5;

		private global::Gtk.HBox hbox5;

		private global::Gtk.HBox hbox7;

		private global::Gtk.ComboBoxEntry cbxEListarUsuario;

		private global::Gtk.VSeparator vseparator6;

		private global::Gtk.HBox hbox6;

		private global::Gtk.Button btnAntCre;

		private global::Gtk.Label lbCountCar;

		private global::Gtk.Button btnSigCre;

		private global::Gtk.VSeparator vseparator4;

		private global::Gtk.HButtonBox hbuttonbox6;

		private global::Gtk.Button buttonFiltrar;

		private global::Gtk.Button btnAdmin;

		private global::Gtk.Button btnCerrar;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProyectoEyS.frmListarCredenciales
			this.Name = "ProyectoEyS.frmListarCredenciales";
			this.Title = global::Mono.Unix.Catalog.GetString("frmListarCredenciales");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			// Container child ProyectoEyS.frmListarCredenciales.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.labelTitulo = new global::Gtk.Label();
			this.labelTitulo.HeightRequest = 35;
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Xalign = 0.03F;
			this.labelTitulo.LabelProp = global::Mono.Unix.Catalog.GetString("Seguridad: Listar Usuarios");
			this.vbox1.Add(this.labelTitulo);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelTitulo]));
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
			this.table1 = new global::Gtk.Table(((uint)(5)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.lbConCre = new global::Gtk.Label();
			this.lbConCre.WidthRequest = 175;
			this.lbConCre.HeightRequest = 20;
			this.lbConCre.Name = "lbConCre";
			this.lbConCre.Xalign = 0F;
			this.lbConCre.LabelProp = global::Mono.Unix.Catalog.GetString("Contraseña:");
			this.table1.Add(this.lbConCre);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.lbConCre]));
			w3.TopAttach = ((uint)(2));
			w3.BottomAttach = ((uint)(3));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbContraseña = new global::Gtk.Label();
			this.lbContraseña.Name = "lbContraseña";
			this.lbContraseña.Xalign = 0F;
			this.lbContraseña.LabelProp = global::Mono.Unix.Catalog.GetString("Texto de ejemplo");
			this.table1.Add(this.lbContraseña);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.lbContraseña]));
			w4.TopAttach = ((uint)(2));
			w4.BottomAttach = ((uint)(3));
			w4.LeftAttach = ((uint)(1));
			w4.RightAttach = ((uint)(2));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbEmpCre = new global::Gtk.Label();
			this.lbEmpCre.WidthRequest = 175;
			this.lbEmpCre.HeightRequest = 20;
			this.lbEmpCre.Name = "lbEmpCre";
			this.lbEmpCre.Xalign = 0F;
			this.lbEmpCre.LabelProp = global::Mono.Unix.Catalog.GetString("Empleado:");
			this.table1.Add(this.lbEmpCre);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.lbEmpCre]));
			w5.TopAttach = ((uint)(3));
			w5.BottomAttach = ((uint)(4));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbEmpleado = new global::Gtk.Label();
			this.lbEmpleado.Name = "lbEmpleado";
			this.lbEmpleado.Xalign = 0F;
			this.lbEmpleado.LabelProp = global::Mono.Unix.Catalog.GetString("Texto de ejemplo");
			this.table1.Add(this.lbEmpleado);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.lbEmpleado]));
			w6.TopAttach = ((uint)(3));
			w6.BottomAttach = ((uint)(4));
			w6.LeftAttach = ((uint)(1));
			w6.RightAttach = ((uint)(2));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbID = new global::Gtk.Label();
			this.lbID.WidthRequest = 260;
			this.lbID.Name = "lbID";
			this.lbID.Xalign = 0F;
			this.lbID.LabelProp = global::Mono.Unix.Catalog.GetString("Texto de ejemplo");
			this.table1.Add(this.lbID);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.lbID]));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbIDCre = new global::Gtk.Label();
			this.lbIDCre.WidthRequest = 175;
			this.lbIDCre.HeightRequest = 20;
			this.lbIDCre.Name = "lbIDCre";
			this.lbIDCre.Xalign = 0F;
			this.lbIDCre.LabelProp = global::Mono.Unix.Catalog.GetString("ID:");
			this.table1.Add(this.lbIDCre);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.lbIDCre]));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbNombre = new global::Gtk.Label();
			this.lbNombre.Name = "lbNombre";
			this.lbNombre.Xalign = 0F;
			this.lbNombre.LabelProp = global::Mono.Unix.Catalog.GetString("Texto de ejemplo");
			this.table1.Add(this.lbNombre);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.lbNombre]));
			w9.TopAttach = ((uint)(1));
			w9.BottomAttach = ((uint)(2));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbNomCre = new global::Gtk.Label();
			this.lbNomCre.WidthRequest = 175;
			this.lbNomCre.HeightRequest = 20;
			this.lbNomCre.Name = "lbNomCre";
			this.lbNomCre.Xalign = 0F;
			this.lbNomCre.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre de Usuario:");
			this.table1.Add(this.lbNomCre);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.lbNomCre]));
			w10.TopAttach = ((uint)(1));
			w10.BottomAttach = ((uint)(2));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbRol = new global::Gtk.Label();
			this.lbRol.Name = "lbRol";
			this.lbRol.Xalign = 0F;
			this.lbRol.LabelProp = global::Mono.Unix.Catalog.GetString("Texto de ejemplo");
			this.table1.Add(this.lbRol);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.lbRol]));
			w11.TopAttach = ((uint)(4));
			w11.BottomAttach = ((uint)(5));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbRolCre = new global::Gtk.Label();
			this.lbRolCre.WidthRequest = 175;
			this.lbRolCre.HeightRequest = 20;
			this.lbRolCre.Name = "lbRolCre";
			this.lbRolCre.Xalign = 0F;
			this.lbRolCre.LabelProp = global::Mono.Unix.Catalog.GetString("Rol:");
			this.table1.Add(this.lbRolCre);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.lbRolCre]));
			w12.TopAttach = ((uint)(4));
			w12.BottomAttach = ((uint)(5));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add(this.table1);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.table1]));
			w13.Position = 1;
			w13.Expand = false;
			w13.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vseparator2 = new global::Gtk.VSeparator();
			this.vseparator2.WidthRequest = 18;
			this.vseparator2.Name = "vseparator2";
			this.hbox1.Add(this.vseparator2);
			global::Gtk.Box.BoxChild w14 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vseparator2]));
			w14.Position = 2;
			w14.Expand = false;
			w14.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w15 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w15.Position = 1;
			w15.Expand = false;
			w15.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.HeightRequest = 19;
			this.hseparator1.Name = "hseparator1";
			this.vbox1.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w16 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hseparator1]));
			w16.Position = 2;
			w16.Expand = false;
			w16.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.scrolled = new global::Gtk.ScrolledWindow();
			this.scrolled.Name = "scrolled";
			this.scrolled.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolled.Gtk.Container+ContainerChild
			this.trvwCredenciales = new global::Gtk.TreeView();
			this.trvwCredenciales.HeightRequest = 150;
			this.trvwCredenciales.CanFocus = true;
			this.trvwCredenciales.Name = "trvwCredenciales";
			this.scrolled.Add(this.trvwCredenciales);
			this.vbox1.Add(this.scrolled);
			global::Gtk.Box.BoxChild w18 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.scrolled]));
			w18.Position = 3;
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
			global::Gtk.Box.BoxChild w19 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vseparator5]));
			w19.Position = 0;
			w19.Expand = false;
			w19.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.cbxEListarUsuario = global::Gtk.ComboBoxEntry.NewText();
			this.cbxEListarUsuario.Name = "cbxEListarUsuario";
			this.hbox7.Add(this.cbxEListarUsuario);
			global::Gtk.Box.BoxChild w20 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.cbxEListarUsuario]));
			w20.Position = 0;
			w20.Expand = false;
			w20.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.vseparator6 = new global::Gtk.VSeparator();
			this.vseparator6.WidthRequest = 18;
			this.vseparator6.Name = "vseparator6";
			this.hbox7.Add(this.vseparator6);
			global::Gtk.Box.BoxChild w21 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.vseparator6]));
			w21.Position = 1;
			w21.Expand = false;
			w21.Fill = false;
			this.hbox5.Add(this.hbox7);
			global::Gtk.Box.BoxChild w22 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.hbox7]));
			w22.Position = 0;
			w22.Expand = false;
			w22.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.btnAntCre = new global::Gtk.Button();
			this.btnAntCre.WidthRequest = 48;
			this.btnAntCre.HeightRequest = 48;
			this.btnAntCre.CanFocus = true;
			this.btnAntCre.Name = "btnAntCre";
			this.btnAntCre.UseUnderline = true;
			this.btnAntCre.Label = global::Mono.Unix.Catalog.GetString("<");
			this.hbox6.Add(this.btnAntCre);
			global::Gtk.Box.BoxChild w23 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.btnAntCre]));
			w23.Position = 0;
			w23.Expand = false;
			w23.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.lbCountCar = new global::Gtk.Label();
			this.lbCountCar.WidthRequest = 98;
			this.lbCountCar.Name = "lbCountCar";
			this.lbCountCar.LabelProp = global::Mono.Unix.Catalog.GetString("999/999");
			this.hbox6.Add(this.lbCountCar);
			global::Gtk.Box.BoxChild w24 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.lbCountCar]));
			w24.Position = 1;
			w24.Expand = false;
			w24.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.btnSigCre = new global::Gtk.Button();
			this.btnSigCre.WidthRequest = 48;
			this.btnSigCre.HeightRequest = 48;
			this.btnSigCre.CanFocus = true;
			this.btnSigCre.Name = "btnSigCre";
			this.btnSigCre.UseUnderline = true;
			this.btnSigCre.Label = global::Mono.Unix.Catalog.GetString(">");
			this.hbox6.Add(this.btnSigCre);
			global::Gtk.Box.BoxChild w25 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.btnSigCre]));
			w25.Position = 2;
			w25.Expand = false;
			w25.Fill = false;
			this.hbox5.Add(this.hbox6);
			global::Gtk.Box.BoxChild w26 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.hbox6]));
			w26.Position = 1;
			w26.Expand = false;
			w26.Fill = false;
			this.hbox4.Add(this.hbox5);
			global::Gtk.Box.BoxChild w27 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.hbox5]));
			w27.Position = 1;
			w27.Expand = false;
			w27.Fill = false;
			// Container child hbox4.Gtk.Box+BoxChild
			this.vseparator4 = new global::Gtk.VSeparator();
			this.vseparator4.WidthRequest = 18;
			this.vseparator4.Name = "vseparator4";
			this.hbox4.Add(this.vseparator4);
			global::Gtk.Box.BoxChild w28 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.vseparator4]));
			w28.Position = 2;
			w28.Expand = false;
			w28.Fill = false;
			this.hbox2.Add(this.hbox4);
			global::Gtk.Box.BoxChild w29 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.hbox4]));
			w29.Position = 0;
			w29.Expand = false;
			w29.Fill = false;
			this.vbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w30 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w30.Position = 4;
			w30.Expand = false;
			w30.Fill = false;
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
			global::Gtk.ButtonBox.ButtonBoxChild w31 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.buttonFiltrar]));
			w31.Expand = false;
			w31.Fill = false;
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.btnAdmin = new global::Gtk.Button();
			this.btnAdmin.WidthRequest = 90;
			this.btnAdmin.HeightRequest = 30;
			this.btnAdmin.CanFocus = true;
			this.btnAdmin.Name = "btnAdmin";
			this.btnAdmin.UseUnderline = true;
			this.btnAdmin.Label = global::Mono.Unix.Catalog.GetString("Administrar");
			this.hbuttonbox6.Add(this.btnAdmin);
			global::Gtk.ButtonBox.ButtonBoxChild w32 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.btnAdmin]));
			w32.Position = 1;
			w32.Expand = false;
			w32.Fill = false;
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.btnCerrar = new global::Gtk.Button();
			this.btnCerrar.CanFocus = true;
			this.btnCerrar.Name = "btnCerrar";
			this.btnCerrar.UseUnderline = true;
			this.btnCerrar.Label = global::Mono.Unix.Catalog.GetString("Cerrar");
			this.hbuttonbox6.Add(this.btnCerrar);
			global::Gtk.ButtonBox.ButtonBoxChild w33 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.btnCerrar]));
			w33.Position = 2;
			w33.Expand = false;
			w33.Fill = false;
			this.vbox1.Add(this.hbuttonbox6);
			global::Gtk.Box.BoxChild w34 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbuttonbox6]));
			w34.Position = 5;
			w34.Expand = false;
			w34.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 490;
			this.DefaultHeight = 458;
			this.Show();
			this.trvwCredenciales.CursorChanged += new global::System.EventHandler(this.OnTrvwCredencialesCursorChanged);
			this.cbxEListarUsuario.Changed += new global::System.EventHandler(this.OnCbxEListarUsuarioChanged);
			this.btnAntCre.Clicked += new global::System.EventHandler(this.OnBtnAntCreClicked);
			this.btnSigCre.Clicked += new global::System.EventHandler(this.OnBtnSigCreClicked);
			this.buttonFiltrar.Clicked += new global::System.EventHandler(this.OnButtonFiltrarClicked);
			this.btnAdmin.Clicked += new global::System.EventHandler(this.OnBtnAdminClicked);
			this.btnCerrar.Clicked += new global::System.EventHandler(this.OnBtnCerrarClicked);
		}
	}
}
