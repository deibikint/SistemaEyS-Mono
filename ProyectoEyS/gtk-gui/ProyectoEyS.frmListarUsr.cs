
// This file has been generated by the GUI designer. Do not modify.
namespace ProyectoEyS
{
	public partial class frmListarUsr
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Label labelListUsr;

		private global::Gtk.HBox hbox1;

		private global::Gtk.VSeparator vseparator3;

		private global::Gtk.Table table1;

		private global::Gtk.Label lbApellido;

		private global::Gtk.Label lbApellidoUsr;

		private global::Gtk.Label lbCargo;

		private global::Gtk.Label lbCargoUsr;

		private global::Gtk.Label lbCedula;

		private global::Gtk.Label lbCedulaUsr;

		private global::Gtk.Label lbDept;

		private global::Gtk.Label lbDeptUsr;

		private global::Gtk.TextView lbDirec;

		private global::Gtk.Label lbEmailCorp;

		private global::Gtk.Label lbEmailCorpUsr;

		private global::Gtk.Label lbEmailPer;

		private global::Gtk.Label lbEmailPerUsr;

		private global::Gtk.Label lbFechaIngr;

		private global::Gtk.Label lbFechaNac;

		private global::Gtk.Label lbFecIngUsr;

		private global::Gtk.Label lbFecIngUsr2;

		private global::Gtk.Label lbID;

		private global::Gtk.Label lbIDUsr;

		private global::Gtk.Label lbNombre;

		private global::Gtk.Label lbNombreUsr;

		private global::Gtk.TextView lbObs;

		private global::Gtk.Label lbObsUsr;

		private global::Gtk.Label lbObsUsr1;

		private global::Gtk.Label lbSexo;

		private global::Gtk.Label lbSexoUsr;

		private global::Gtk.Label lbTel;

		private global::Gtk.Label lbTelUsr;

		private global::Gtk.Label lbTrab;

		private global::Gtk.Label lbTrabUsr;

		private global::Gtk.Label lbUsername;

		private global::Gtk.Label lbUsernameUsr;

		private global::Gtk.VSeparator vseparator2;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.VBox scrolled;

		private global::Gtk.HBox hbox3;

		private global::Gtk.Label label1;

		private global::Gtk.Entry txbBuscar;

		private global::Gtk.ScrolledWindow GtkScrolledWindow;

		private global::Gtk.TreeView trvwListEmp;

		private global::Gtk.HBox hbox2;

		private global::Gtk.HBox hbox4;

		private global::Gtk.HBox hbox5;

		private global::Gtk.VSeparator vseparator5;

		private global::Gtk.HBox hbox6;

		private global::Gtk.HBox hbox7;

		private global::Gtk.ComboBoxEntry cbxEListarUsr;

		private global::Gtk.VSeparator vseparator6;

		private global::Gtk.HBox hbox8;

		private global::Gtk.Button btnAntUsr;

		private global::Gtk.Label lbCountEmp;

		private global::Gtk.Button btnSigUsr;

		private global::Gtk.VSeparator vseparator4;

		private global::Gtk.HButtonBox hbuttonbox6;

		private global::Gtk.Button buttonFiltrar;

		private global::Gtk.Button buttonEvento;

		private global::Gtk.Button buttonAdmin;

		private global::Gtk.Button buttonClose;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProyectoEyS.frmListarUsr
			this.Name = "ProyectoEyS.frmListarUsr";
			this.Title = global::Mono.Unix.Catalog.GetString("frmListarUsr");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			// Container child ProyectoEyS.frmListarUsr.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.labelListUsr = new global::Gtk.Label();
			this.labelListUsr.HeightRequest = 23;
			this.labelListUsr.Name = "labelListUsr";
			this.labelListUsr.Xalign = 0.03F;
			this.labelListUsr.LabelProp = global::Mono.Unix.Catalog.GetString("Listar empleados");
			this.vbox1.Add(this.labelListUsr);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelListUsr]));
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
			this.table1 = new global::Gtk.Table(((uint)(16)), ((uint)(2)), false);
			this.table1.Name = "table1";
			this.table1.RowSpacing = ((uint)(6));
			this.table1.ColumnSpacing = ((uint)(6));
			// Container child table1.Gtk.Table+TableChild
			this.lbApellido = new global::Gtk.Label();
			this.lbApellido.Name = "lbApellido";
			this.lbApellido.Xalign = 0F;
			this.lbApellido.LabelProp = global::Mono.Unix.Catalog.GetString("Texto de ejemplo");
			this.table1.Add(this.lbApellido);
			global::Gtk.Table.TableChild w3 = ((global::Gtk.Table.TableChild)(this.table1[this.lbApellido]));
			w3.TopAttach = ((uint)(3));
			w3.BottomAttach = ((uint)(4));
			w3.LeftAttach = ((uint)(1));
			w3.RightAttach = ((uint)(2));
			w3.XOptions = ((global::Gtk.AttachOptions)(4));
			w3.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbApellidoUsr = new global::Gtk.Label();
			this.lbApellidoUsr.WidthRequest = 175;
			this.lbApellidoUsr.Name = "lbApellidoUsr";
			this.lbApellidoUsr.Xalign = 0F;
			this.lbApellidoUsr.LabelProp = global::Mono.Unix.Catalog.GetString("Apellidos:");
			this.table1.Add(this.lbApellidoUsr);
			global::Gtk.Table.TableChild w4 = ((global::Gtk.Table.TableChild)(this.table1[this.lbApellidoUsr]));
			w4.TopAttach = ((uint)(3));
			w4.BottomAttach = ((uint)(4));
			w4.XOptions = ((global::Gtk.AttachOptions)(4));
			w4.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbCargo = new global::Gtk.Label();
			this.lbCargo.Name = "lbCargo";
			this.lbCargo.Xalign = 0F;
			this.lbCargo.LabelProp = global::Mono.Unix.Catalog.GetString("Texto de ejemplo");
			this.table1.Add(this.lbCargo);
			global::Gtk.Table.TableChild w5 = ((global::Gtk.Table.TableChild)(this.table1[this.lbCargo]));
			w5.TopAttach = ((uint)(7));
			w5.BottomAttach = ((uint)(8));
			w5.LeftAttach = ((uint)(1));
			w5.RightAttach = ((uint)(2));
			w5.XOptions = ((global::Gtk.AttachOptions)(4));
			w5.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbCargoUsr = new global::Gtk.Label();
			this.lbCargoUsr.WidthRequest = 175;
			this.lbCargoUsr.Name = "lbCargoUsr";
			this.lbCargoUsr.Xalign = 0F;
			this.lbCargoUsr.LabelProp = global::Mono.Unix.Catalog.GetString("Cargo:");
			this.table1.Add(this.lbCargoUsr);
			global::Gtk.Table.TableChild w6 = ((global::Gtk.Table.TableChild)(this.table1[this.lbCargoUsr]));
			w6.TopAttach = ((uint)(7));
			w6.BottomAttach = ((uint)(8));
			w6.XOptions = ((global::Gtk.AttachOptions)(4));
			w6.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbCedula = new global::Gtk.Label();
			this.lbCedula.Name = "lbCedula";
			this.lbCedula.Xalign = 0F;
			this.lbCedula.LabelProp = global::Mono.Unix.Catalog.GetString("XXX-XXXXXX-XXXX");
			this.table1.Add(this.lbCedula);
			global::Gtk.Table.TableChild w7 = ((global::Gtk.Table.TableChild)(this.table1[this.lbCedula]));
			w7.TopAttach = ((uint)(5));
			w7.BottomAttach = ((uint)(6));
			w7.LeftAttach = ((uint)(1));
			w7.RightAttach = ((uint)(2));
			w7.XOptions = ((global::Gtk.AttachOptions)(4));
			w7.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbCedulaUsr = new global::Gtk.Label();
			this.lbCedulaUsr.WidthRequest = 175;
			this.lbCedulaUsr.Name = "lbCedulaUsr";
			this.lbCedulaUsr.Xalign = 0F;
			this.lbCedulaUsr.LabelProp = global::Mono.Unix.Catalog.GetString("Cédula:");
			this.table1.Add(this.lbCedulaUsr);
			global::Gtk.Table.TableChild w8 = ((global::Gtk.Table.TableChild)(this.table1[this.lbCedulaUsr]));
			w8.TopAttach = ((uint)(5));
			w8.BottomAttach = ((uint)(6));
			w8.XOptions = ((global::Gtk.AttachOptions)(4));
			w8.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbDept = new global::Gtk.Label();
			this.lbDept.Name = "lbDept";
			this.lbDept.Xalign = 0F;
			this.lbDept.LabelProp = global::Mono.Unix.Catalog.GetString("Texto de ejemplo");
			this.table1.Add(this.lbDept);
			global::Gtk.Table.TableChild w9 = ((global::Gtk.Table.TableChild)(this.table1[this.lbDept]));
			w9.TopAttach = ((uint)(6));
			w9.BottomAttach = ((uint)(7));
			w9.LeftAttach = ((uint)(1));
			w9.RightAttach = ((uint)(2));
			w9.XOptions = ((global::Gtk.AttachOptions)(4));
			w9.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbDeptUsr = new global::Gtk.Label();
			this.lbDeptUsr.WidthRequest = 175;
			this.lbDeptUsr.Name = "lbDeptUsr";
			this.lbDeptUsr.Xalign = 0F;
			this.lbDeptUsr.LabelProp = global::Mono.Unix.Catalog.GetString("Departamento:");
			this.table1.Add(this.lbDeptUsr);
			global::Gtk.Table.TableChild w10 = ((global::Gtk.Table.TableChild)(this.table1[this.lbDeptUsr]));
			w10.TopAttach = ((uint)(6));
			w10.BottomAttach = ((uint)(7));
			w10.XOptions = ((global::Gtk.AttachOptions)(4));
			w10.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbDirec = new global::Gtk.TextView();
			this.lbDirec.WidthRequest = 262;
			this.lbDirec.Sensitive = false;
			this.lbDirec.CanFocus = true;
			this.lbDirec.Name = "lbDirec";
			this.lbDirec.WrapMode = ((global::Gtk.WrapMode)(3));
			this.table1.Add(this.lbDirec);
			global::Gtk.Table.TableChild w11 = ((global::Gtk.Table.TableChild)(this.table1[this.lbDirec]));
			w11.TopAttach = ((uint)(15));
			w11.BottomAttach = ((uint)(16));
			w11.LeftAttach = ((uint)(1));
			w11.RightAttach = ((uint)(2));
			w11.XOptions = ((global::Gtk.AttachOptions)(4));
			w11.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbEmailCorp = new global::Gtk.Label();
			this.lbEmailCorp.Name = "lbEmailCorp";
			this.lbEmailCorp.Xalign = 0F;
			this.lbEmailCorp.LabelProp = global::Mono.Unix.Catalog.GetString("texto@ejemplo.com");
			this.table1.Add(this.lbEmailCorp);
			global::Gtk.Table.TableChild w12 = ((global::Gtk.Table.TableChild)(this.table1[this.lbEmailCorp]));
			w12.TopAttach = ((uint)(8));
			w12.BottomAttach = ((uint)(9));
			w12.LeftAttach = ((uint)(1));
			w12.RightAttach = ((uint)(2));
			w12.XOptions = ((global::Gtk.AttachOptions)(4));
			w12.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbEmailCorpUsr = new global::Gtk.Label();
			this.lbEmailCorpUsr.WidthRequest = 175;
			this.lbEmailCorpUsr.Name = "lbEmailCorpUsr";
			this.lbEmailCorpUsr.Xalign = 0F;
			this.lbEmailCorpUsr.LabelProp = global::Mono.Unix.Catalog.GetString("Email corporativo:");
			this.table1.Add(this.lbEmailCorpUsr);
			global::Gtk.Table.TableChild w13 = ((global::Gtk.Table.TableChild)(this.table1[this.lbEmailCorpUsr]));
			w13.TopAttach = ((uint)(8));
			w13.BottomAttach = ((uint)(9));
			w13.XOptions = ((global::Gtk.AttachOptions)(4));
			w13.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbEmailPer = new global::Gtk.Label();
			this.lbEmailPer.Name = "lbEmailPer";
			this.lbEmailPer.Xalign = 0F;
			this.lbEmailPer.LabelProp = global::Mono.Unix.Catalog.GetString("texto@ejemplo.com");
			this.table1.Add(this.lbEmailPer);
			global::Gtk.Table.TableChild w14 = ((global::Gtk.Table.TableChild)(this.table1[this.lbEmailPer]));
			w14.TopAttach = ((uint)(9));
			w14.BottomAttach = ((uint)(10));
			w14.LeftAttach = ((uint)(1));
			w14.RightAttach = ((uint)(2));
			w14.XOptions = ((global::Gtk.AttachOptions)(4));
			w14.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbEmailPerUsr = new global::Gtk.Label();
			this.lbEmailPerUsr.WidthRequest = 175;
			this.lbEmailPerUsr.Name = "lbEmailPerUsr";
			this.lbEmailPerUsr.Xalign = 0F;
			this.lbEmailPerUsr.LabelProp = global::Mono.Unix.Catalog.GetString("Email personal:");
			this.table1.Add(this.lbEmailPerUsr);
			global::Gtk.Table.TableChild w15 = ((global::Gtk.Table.TableChild)(this.table1[this.lbEmailPerUsr]));
			w15.TopAttach = ((uint)(9));
			w15.BottomAttach = ((uint)(10));
			w15.XOptions = ((global::Gtk.AttachOptions)(4));
			w15.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbFechaIngr = new global::Gtk.Label();
			this.lbFechaIngr.Name = "lbFechaIngr";
			this.lbFechaIngr.Xalign = 0F;
			this.lbFechaIngr.LabelProp = global::Mono.Unix.Catalog.GetString("DD:MM:YY");
			this.table1.Add(this.lbFechaIngr);
			global::Gtk.Table.TableChild w16 = ((global::Gtk.Table.TableChild)(this.table1[this.lbFechaIngr]));
			w16.TopAttach = ((uint)(11));
			w16.BottomAttach = ((uint)(12));
			w16.LeftAttach = ((uint)(1));
			w16.RightAttach = ((uint)(2));
			w16.XOptions = ((global::Gtk.AttachOptions)(4));
			w16.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbFechaNac = new global::Gtk.Label();
			this.lbFechaNac.Name = "lbFechaNac";
			this.lbFechaNac.Xalign = 0F;
			this.lbFechaNac.LabelProp = global::Mono.Unix.Catalog.GetString("DD:MM:YY");
			this.table1.Add(this.lbFechaNac);
			global::Gtk.Table.TableChild w17 = ((global::Gtk.Table.TableChild)(this.table1[this.lbFechaNac]));
			w17.TopAttach = ((uint)(10));
			w17.BottomAttach = ((uint)(11));
			w17.LeftAttach = ((uint)(1));
			w17.RightAttach = ((uint)(2));
			w17.XOptions = ((global::Gtk.AttachOptions)(4));
			w17.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbFecIngUsr = new global::Gtk.Label();
			this.lbFecIngUsr.WidthRequest = 175;
			this.lbFecIngUsr.Name = "lbFecIngUsr";
			this.lbFecIngUsr.Xalign = 0F;
			this.lbFecIngUsr.LabelProp = global::Mono.Unix.Catalog.GetString("Fecha de ingreso:");
			this.table1.Add(this.lbFecIngUsr);
			global::Gtk.Table.TableChild w18 = ((global::Gtk.Table.TableChild)(this.table1[this.lbFecIngUsr]));
			w18.TopAttach = ((uint)(11));
			w18.BottomAttach = ((uint)(12));
			w18.XOptions = ((global::Gtk.AttachOptions)(4));
			w18.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbFecIngUsr2 = new global::Gtk.Label();
			this.lbFecIngUsr2.WidthRequest = 175;
			this.lbFecIngUsr2.Name = "lbFecIngUsr2";
			this.lbFecIngUsr2.Xalign = 0F;
			this.lbFecIngUsr2.LabelProp = global::Mono.Unix.Catalog.GetString("Fecha de nacimiento:");
			this.table1.Add(this.lbFecIngUsr2);
			global::Gtk.Table.TableChild w19 = ((global::Gtk.Table.TableChild)(this.table1[this.lbFecIngUsr2]));
			w19.TopAttach = ((uint)(10));
			w19.BottomAttach = ((uint)(11));
			w19.XOptions = ((global::Gtk.AttachOptions)(4));
			w19.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbID = new global::Gtk.Label();
			this.lbID.Name = "lbID";
			this.lbID.Xalign = 0F;
			this.lbID.LabelProp = global::Mono.Unix.Catalog.GetString("XXXXXXXX");
			this.table1.Add(this.lbID);
			global::Gtk.Table.TableChild w20 = ((global::Gtk.Table.TableChild)(this.table1[this.lbID]));
			w20.LeftAttach = ((uint)(1));
			w20.RightAttach = ((uint)(2));
			w20.XOptions = ((global::Gtk.AttachOptions)(4));
			w20.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbIDUsr = new global::Gtk.Label();
			this.lbIDUsr.WidthRequest = 175;
			this.lbIDUsr.HeightRequest = 0;
			this.lbIDUsr.Name = "lbIDUsr";
			this.lbIDUsr.Xalign = 0F;
			this.lbIDUsr.LabelProp = global::Mono.Unix.Catalog.GetString("ID:");
			this.table1.Add(this.lbIDUsr);
			global::Gtk.Table.TableChild w21 = ((global::Gtk.Table.TableChild)(this.table1[this.lbIDUsr]));
			w21.XOptions = ((global::Gtk.AttachOptions)(4));
			w21.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbNombre = new global::Gtk.Label();
			this.lbNombre.Name = "lbNombre";
			this.lbNombre.Xalign = 0F;
			this.lbNombre.LabelProp = global::Mono.Unix.Catalog.GetString("Texto de ejemplo");
			this.table1.Add(this.lbNombre);
			global::Gtk.Table.TableChild w22 = ((global::Gtk.Table.TableChild)(this.table1[this.lbNombre]));
			w22.TopAttach = ((uint)(2));
			w22.BottomAttach = ((uint)(3));
			w22.LeftAttach = ((uint)(1));
			w22.RightAttach = ((uint)(2));
			w22.XOptions = ((global::Gtk.AttachOptions)(4));
			w22.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbNombreUsr = new global::Gtk.Label();
			this.lbNombreUsr.WidthRequest = 175;
			this.lbNombreUsr.Name = "lbNombreUsr";
			this.lbNombreUsr.Xalign = 0F;
			this.lbNombreUsr.LabelProp = global::Mono.Unix.Catalog.GetString("Nombres:");
			this.table1.Add(this.lbNombreUsr);
			global::Gtk.Table.TableChild w23 = ((global::Gtk.Table.TableChild)(this.table1[this.lbNombreUsr]));
			w23.TopAttach = ((uint)(2));
			w23.BottomAttach = ((uint)(3));
			w23.XOptions = ((global::Gtk.AttachOptions)(4));
			w23.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbObs = new global::Gtk.TextView();
			this.lbObs.Sensitive = false;
			this.lbObs.CanFocus = true;
			this.lbObs.Name = "lbObs";
			this.lbObs.WrapMode = ((global::Gtk.WrapMode)(3));
			this.table1.Add(this.lbObs);
			global::Gtk.Table.TableChild w24 = ((global::Gtk.Table.TableChild)(this.table1[this.lbObs]));
			w24.TopAttach = ((uint)(14));
			w24.BottomAttach = ((uint)(15));
			w24.LeftAttach = ((uint)(1));
			w24.RightAttach = ((uint)(2));
			w24.XOptions = ((global::Gtk.AttachOptions)(4));
			w24.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbObsUsr = new global::Gtk.Label();
			this.lbObsUsr.WidthRequest = 175;
			this.lbObsUsr.Name = "lbObsUsr";
			this.lbObsUsr.Xalign = 0F;
			this.lbObsUsr.Yalign = 0.2F;
			this.lbObsUsr.LabelProp = global::Mono.Unix.Catalog.GetString("Observación:");
			this.table1.Add(this.lbObsUsr);
			global::Gtk.Table.TableChild w25 = ((global::Gtk.Table.TableChild)(this.table1[this.lbObsUsr]));
			w25.TopAttach = ((uint)(14));
			w25.BottomAttach = ((uint)(15));
			w25.XOptions = ((global::Gtk.AttachOptions)(4));
			w25.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbObsUsr1 = new global::Gtk.Label();
			this.lbObsUsr1.WidthRequest = 175;
			this.lbObsUsr1.Name = "lbObsUsr1";
			this.lbObsUsr1.Xalign = 0F;
			this.lbObsUsr1.Yalign = 0.2F;
			this.lbObsUsr1.LabelProp = global::Mono.Unix.Catalog.GetString("Dirección:");
			this.table1.Add(this.lbObsUsr1);
			global::Gtk.Table.TableChild w26 = ((global::Gtk.Table.TableChild)(this.table1[this.lbObsUsr1]));
			w26.TopAttach = ((uint)(15));
			w26.BottomAttach = ((uint)(16));
			w26.XOptions = ((global::Gtk.AttachOptions)(4));
			w26.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbSexo = new global::Gtk.Label();
			this.lbSexo.Name = "lbSexo";
			this.lbSexo.Xalign = 0F;
			this.lbSexo.LabelProp = global::Mono.Unix.Catalog.GetString("M/F");
			this.table1.Add(this.lbSexo);
			global::Gtk.Table.TableChild w27 = ((global::Gtk.Table.TableChild)(this.table1[this.lbSexo]));
			w27.TopAttach = ((uint)(4));
			w27.BottomAttach = ((uint)(5));
			w27.LeftAttach = ((uint)(1));
			w27.RightAttach = ((uint)(2));
			w27.XOptions = ((global::Gtk.AttachOptions)(4));
			w27.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbSexoUsr = new global::Gtk.Label();
			this.lbSexoUsr.WidthRequest = 175;
			this.lbSexoUsr.Name = "lbSexoUsr";
			this.lbSexoUsr.Xalign = 0F;
			this.lbSexoUsr.LabelProp = global::Mono.Unix.Catalog.GetString("Sexo:");
			this.table1.Add(this.lbSexoUsr);
			global::Gtk.Table.TableChild w28 = ((global::Gtk.Table.TableChild)(this.table1[this.lbSexoUsr]));
			w28.TopAttach = ((uint)(4));
			w28.BottomAttach = ((uint)(5));
			w28.XOptions = ((global::Gtk.AttachOptions)(4));
			w28.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbTel = new global::Gtk.Label();
			this.lbTel.Name = "lbTel";
			this.lbTel.Xalign = 0F;
			this.lbTel.LabelProp = global::Mono.Unix.Catalog.GetString("Texto de ejemplo");
			this.table1.Add(this.lbTel);
			global::Gtk.Table.TableChild w29 = ((global::Gtk.Table.TableChild)(this.table1[this.lbTel]));
			w29.TopAttach = ((uint)(13));
			w29.BottomAttach = ((uint)(14));
			w29.LeftAttach = ((uint)(1));
			w29.RightAttach = ((uint)(2));
			w29.XOptions = ((global::Gtk.AttachOptions)(4));
			w29.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbTelUsr = new global::Gtk.Label();
			this.lbTelUsr.WidthRequest = 175;
			this.lbTelUsr.Name = "lbTelUsr";
			this.lbTelUsr.Xalign = 0F;
			this.lbTelUsr.LabelProp = global::Mono.Unix.Catalog.GetString("Teléfono:");
			this.table1.Add(this.lbTelUsr);
			global::Gtk.Table.TableChild w30 = ((global::Gtk.Table.TableChild)(this.table1[this.lbTelUsr]));
			w30.TopAttach = ((uint)(13));
			w30.BottomAttach = ((uint)(14));
			w30.XOptions = ((global::Gtk.AttachOptions)(4));
			w30.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbTrab = new global::Gtk.Label();
			this.lbTrab.Name = "lbTrab";
			this.lbTrab.Xalign = 0F;
			this.lbTrab.LabelProp = global::Mono.Unix.Catalog.GetString("SI / NO");
			this.table1.Add(this.lbTrab);
			global::Gtk.Table.TableChild w31 = ((global::Gtk.Table.TableChild)(this.table1[this.lbTrab]));
			w31.TopAttach = ((uint)(12));
			w31.BottomAttach = ((uint)(13));
			w31.LeftAttach = ((uint)(1));
			w31.RightAttach = ((uint)(2));
			w31.XOptions = ((global::Gtk.AttachOptions)(4));
			w31.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbTrabUsr = new global::Gtk.Label();
			this.lbTrabUsr.WidthRequest = 175;
			this.lbTrabUsr.Name = "lbTrabUsr";
			this.lbTrabUsr.Xalign = 0F;
			this.lbTrabUsr.LabelProp = global::Mono.Unix.Catalog.GetString("Activo:");
			this.table1.Add(this.lbTrabUsr);
			global::Gtk.Table.TableChild w32 = ((global::Gtk.Table.TableChild)(this.table1[this.lbTrabUsr]));
			w32.TopAttach = ((uint)(12));
			w32.BottomAttach = ((uint)(13));
			w32.XOptions = ((global::Gtk.AttachOptions)(4));
			w32.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbUsername = new global::Gtk.Label();
			this.lbUsername.Name = "lbUsername";
			this.lbUsername.Xalign = 0F;
			this.lbUsername.LabelProp = global::Mono.Unix.Catalog.GetString("Sin usuario");
			this.table1.Add(this.lbUsername);
			global::Gtk.Table.TableChild w33 = ((global::Gtk.Table.TableChild)(this.table1[this.lbUsername]));
			w33.TopAttach = ((uint)(1));
			w33.BottomAttach = ((uint)(2));
			w33.LeftAttach = ((uint)(1));
			w33.RightAttach = ((uint)(2));
			w33.XOptions = ((global::Gtk.AttachOptions)(4));
			w33.YOptions = ((global::Gtk.AttachOptions)(4));
			// Container child table1.Gtk.Table+TableChild
			this.lbUsernameUsr = new global::Gtk.Label();
			this.lbUsernameUsr.WidthRequest = 175;
			this.lbUsernameUsr.HeightRequest = 0;
			this.lbUsernameUsr.Name = "lbUsernameUsr";
			this.lbUsernameUsr.Xalign = 0F;
			this.lbUsernameUsr.LabelProp = global::Mono.Unix.Catalog.GetString("Nombre de Usuario:");
			this.table1.Add(this.lbUsernameUsr);
			global::Gtk.Table.TableChild w34 = ((global::Gtk.Table.TableChild)(this.table1[this.lbUsernameUsr]));
			w34.TopAttach = ((uint)(1));
			w34.BottomAttach = ((uint)(2));
			w34.XOptions = ((global::Gtk.AttachOptions)(4));
			w34.YOptions = ((global::Gtk.AttachOptions)(4));
			this.hbox1.Add(this.table1);
			global::Gtk.Box.BoxChild w35 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.table1]));
			w35.Position = 1;
			w35.Expand = false;
			w35.Fill = false;
			// Container child hbox1.Gtk.Box+BoxChild
			this.vseparator2 = new global::Gtk.VSeparator();
			this.vseparator2.WidthRequest = 18;
			this.vseparator2.Name = "vseparator2";
			this.hbox1.Add(this.vseparator2);
			global::Gtk.Box.BoxChild w36 = ((global::Gtk.Box.BoxChild)(this.hbox1[this.vseparator2]));
			w36.Position = 2;
			w36.Expand = false;
			w36.Fill = false;
			this.vbox1.Add(this.hbox1);
			global::Gtk.Box.BoxChild w37 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox1]));
			w37.Position = 1;
			w37.Expand = false;
			w37.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.Name = "hseparator1";
			this.vbox1.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w38 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hseparator1]));
			w38.Position = 2;
			w38.Expand = false;
			w38.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.scrolled = new global::Gtk.VBox();
			this.scrolled.Name = "scrolled";
			this.scrolled.Spacing = 6;
			// Container child scrolled.Gtk.Box+BoxChild
			this.hbox3 = new global::Gtk.HBox();
			this.hbox3.Name = "hbox3";
			this.hbox3.Spacing = 6;
			// Container child hbox3.Gtk.Box+BoxChild
			this.label1 = new global::Gtk.Label();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString("Buscar:");
			this.hbox3.Add(this.label1);
			global::Gtk.Box.BoxChild w39 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.label1]));
			w39.Position = 0;
			w39.Expand = false;
			w39.Fill = false;
			// Container child hbox3.Gtk.Box+BoxChild
			this.txbBuscar = new global::Gtk.Entry();
			this.txbBuscar.CanFocus = true;
			this.txbBuscar.Name = "txbBuscar";
			this.txbBuscar.IsEditable = true;
			this.txbBuscar.InvisibleChar = '•';
			this.hbox3.Add(this.txbBuscar);
			global::Gtk.Box.BoxChild w40 = ((global::Gtk.Box.BoxChild)(this.hbox3[this.txbBuscar]));
			w40.Position = 1;
			this.scrolled.Add(this.hbox3);
			global::Gtk.Box.BoxChild w41 = ((global::Gtk.Box.BoxChild)(this.scrolled[this.hbox3]));
			w41.Position = 0;
			w41.Expand = false;
			w41.Fill = false;
			// Container child scrolled.Gtk.Box+BoxChild
			this.GtkScrolledWindow = new global::Gtk.ScrolledWindow();
			this.GtkScrolledWindow.Name = "GtkScrolledWindow";
			this.GtkScrolledWindow.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child GtkScrolledWindow.Gtk.Container+ContainerChild
			this.trvwListEmp = new global::Gtk.TreeView();
			this.trvwListEmp.HeightRequest = 110;
			this.trvwListEmp.CanFocus = true;
			this.trvwListEmp.Name = "trvwListEmp";
			this.GtkScrolledWindow.Add(this.trvwListEmp);
			this.scrolled.Add(this.GtkScrolledWindow);
			global::Gtk.Box.BoxChild w43 = ((global::Gtk.Box.BoxChild)(this.scrolled[this.GtkScrolledWindow]));
			w43.Position = 1;
			this.vbox1.Add(this.scrolled);
			global::Gtk.Box.BoxChild w44 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.scrolled]));
			w44.Position = 3;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox2 = new global::Gtk.HBox();
			this.hbox2.Name = "hbox2";
			this.hbox2.Spacing = 6;
			// Container child hbox2.Gtk.Box+BoxChild
			this.hbox4 = new global::Gtk.HBox();
			this.hbox4.Name = "hbox4";
			this.hbox4.Spacing = 6;
			// Container child hbox4.Gtk.Box+BoxChild
			this.hbox5 = new global::Gtk.HBox();
			this.hbox5.HeightRequest = 35;
			this.hbox5.Name = "hbox5";
			this.hbox5.Spacing = 6;
			// Container child hbox5.Gtk.Box+BoxChild
			this.vseparator5 = new global::Gtk.VSeparator();
			this.vseparator5.WidthRequest = 18;
			this.vseparator5.Name = "vseparator5";
			this.hbox5.Add(this.vseparator5);
			global::Gtk.Box.BoxChild w45 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.vseparator5]));
			w45.Position = 0;
			w45.Expand = false;
			w45.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.hbox6 = new global::Gtk.HBox();
			this.hbox6.Name = "hbox6";
			this.hbox6.Spacing = 6;
			// Container child hbox6.Gtk.Box+BoxChild
			this.hbox7 = new global::Gtk.HBox();
			this.hbox7.Name = "hbox7";
			this.hbox7.Spacing = 6;
			// Container child hbox7.Gtk.Box+BoxChild
			this.cbxEListarUsr = global::Gtk.ComboBoxEntry.NewText();
			this.cbxEListarUsr.Name = "cbxEListarUsr";
			this.hbox7.Add(this.cbxEListarUsr);
			global::Gtk.Box.BoxChild w46 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.cbxEListarUsr]));
			w46.Position = 0;
			w46.Expand = false;
			w46.Fill = false;
			// Container child hbox7.Gtk.Box+BoxChild
			this.vseparator6 = new global::Gtk.VSeparator();
			this.vseparator6.WidthRequest = 18;
			this.vseparator6.Name = "vseparator6";
			this.hbox7.Add(this.vseparator6);
			global::Gtk.Box.BoxChild w47 = ((global::Gtk.Box.BoxChild)(this.hbox7[this.vseparator6]));
			w47.Position = 1;
			w47.Expand = false;
			w47.Fill = false;
			this.hbox6.Add(this.hbox7);
			global::Gtk.Box.BoxChild w48 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.hbox7]));
			w48.Position = 0;
			w48.Expand = false;
			w48.Fill = false;
			// Container child hbox6.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.btnAntUsr = new global::Gtk.Button();
			this.btnAntUsr.WidthRequest = 48;
			this.btnAntUsr.CanFocus = true;
			this.btnAntUsr.Name = "btnAntUsr";
			this.btnAntUsr.UseUnderline = true;
			this.btnAntUsr.Label = global::Mono.Unix.Catalog.GetString("<");
			this.hbox8.Add(this.btnAntUsr);
			global::Gtk.Box.BoxChild w49 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.btnAntUsr]));
			w49.Position = 0;
			w49.Expand = false;
			w49.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.lbCountEmp = new global::Gtk.Label();
			this.lbCountEmp.WidthRequest = 98;
			this.lbCountEmp.Name = "lbCountEmp";
			this.lbCountEmp.LabelProp = global::Mono.Unix.Catalog.GetString("999/999");
			this.hbox8.Add(this.lbCountEmp);
			global::Gtk.Box.BoxChild w50 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.lbCountEmp]));
			w50.Position = 1;
			w50.Expand = false;
			w50.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.btnSigUsr = new global::Gtk.Button();
			this.btnSigUsr.WidthRequest = 48;
			this.btnSigUsr.CanFocus = true;
			this.btnSigUsr.Name = "btnSigUsr";
			this.btnSigUsr.UseUnderline = true;
			this.btnSigUsr.Label = global::Mono.Unix.Catalog.GetString(">");
			this.hbox8.Add(this.btnSigUsr);
			global::Gtk.Box.BoxChild w51 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.btnSigUsr]));
			w51.Position = 2;
			w51.Expand = false;
			w51.Fill = false;
			this.hbox6.Add(this.hbox8);
			global::Gtk.Box.BoxChild w52 = ((global::Gtk.Box.BoxChild)(this.hbox6[this.hbox8]));
			w52.Position = 1;
			w52.Expand = false;
			w52.Fill = false;
			this.hbox5.Add(this.hbox6);
			global::Gtk.Box.BoxChild w53 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.hbox6]));
			w53.Position = 1;
			w53.Expand = false;
			w53.Fill = false;
			// Container child hbox5.Gtk.Box+BoxChild
			this.vseparator4 = new global::Gtk.VSeparator();
			this.vseparator4.WidthRequest = 18;
			this.vseparator4.Name = "vseparator4";
			this.hbox5.Add(this.vseparator4);
			global::Gtk.Box.BoxChild w54 = ((global::Gtk.Box.BoxChild)(this.hbox5[this.vseparator4]));
			w54.Position = 2;
			w54.Expand = false;
			w54.Fill = false;
			this.hbox4.Add(this.hbox5);
			global::Gtk.Box.BoxChild w55 = ((global::Gtk.Box.BoxChild)(this.hbox4[this.hbox5]));
			w55.Position = 0;
			w55.Expand = false;
			w55.Fill = false;
			this.hbox2.Add(this.hbox4);
			global::Gtk.Box.BoxChild w56 = ((global::Gtk.Box.BoxChild)(this.hbox2[this.hbox4]));
			w56.Position = 0;
			w56.Expand = false;
			w56.Fill = false;
			this.vbox1.Add(this.hbox2);
			global::Gtk.Box.BoxChild w57 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox2]));
			w57.Position = 4;
			w57.Expand = false;
			w57.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbuttonbox6 = new global::Gtk.HButtonBox();
			this.hbuttonbox6.Name = "hbuttonbox6";
			this.hbuttonbox6.Spacing = 4;
			this.hbuttonbox6.BorderWidth = ((uint)(7));
			this.hbuttonbox6.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.buttonFiltrar = new global::Gtk.Button();
			this.buttonFiltrar.CanFocus = true;
			this.buttonFiltrar.Name = "buttonFiltrar";
			this.buttonFiltrar.UseUnderline = true;
			this.buttonFiltrar.Label = global::Mono.Unix.Catalog.GetString("Filtrar");
			this.hbuttonbox6.Add(this.buttonFiltrar);
			global::Gtk.ButtonBox.ButtonBoxChild w58 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.buttonFiltrar]));
			w58.Expand = false;
			w58.Fill = false;
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.buttonEvento = new global::Gtk.Button();
			this.buttonEvento.WidthRequest = 100;
			this.buttonEvento.HeightRequest = 30;
			this.buttonEvento.CanFocus = true;
			this.buttonEvento.Name = "buttonEvento";
			this.buttonEvento.UseUnderline = true;
			this.buttonEvento.Label = global::Mono.Unix.Catalog.GetString("Evento");
			this.hbuttonbox6.Add(this.buttonEvento);
			global::Gtk.ButtonBox.ButtonBoxChild w59 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.buttonEvento]));
			w59.Position = 1;
			w59.Expand = false;
			w59.Fill = false;
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.buttonAdmin = new global::Gtk.Button();
			this.buttonAdmin.CanFocus = true;
			this.buttonAdmin.Name = "buttonAdmin";
			this.buttonAdmin.UseUnderline = true;
			this.buttonAdmin.Label = global::Mono.Unix.Catalog.GetString("Administrar");
			this.hbuttonbox6.Add(this.buttonAdmin);
			global::Gtk.ButtonBox.ButtonBoxChild w60 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.buttonAdmin]));
			w60.Position = 2;
			w60.Expand = false;
			w60.Fill = false;
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.buttonClose = new global::Gtk.Button();
			this.buttonClose.CanFocus = true;
			this.buttonClose.Name = "buttonClose";
			this.buttonClose.UseUnderline = true;
			this.buttonClose.Label = global::Mono.Unix.Catalog.GetString("Cerrar");
			this.hbuttonbox6.Add(this.buttonClose);
			global::Gtk.ButtonBox.ButtonBoxChild w61 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.buttonClose]));
			w61.Position = 3;
			w61.Expand = false;
			w61.Fill = false;
			this.vbox1.Add(this.hbuttonbox6);
			global::Gtk.Box.BoxChild w62 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbuttonbox6]));
			w62.Position = 5;
			w62.Expand = false;
			w62.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 491;
			this.DefaultHeight = 663;
			this.Show();
			this.txbBuscar.Changed += new global::System.EventHandler(this.OnTxbBuscarChanged);
			this.trvwListEmp.CursorChanged += new global::System.EventHandler(this.OnTrvwListEmpCursorChanged);
			this.cbxEListarUsr.Changed += new global::System.EventHandler(this.OnCbxEListarUsrChanged);
			this.btnAntUsr.Clicked += new global::System.EventHandler(this.OnBtnAntUsrClicked);
			this.btnSigUsr.Clicked += new global::System.EventHandler(this.OnBtnSigUsrClicked);
			this.buttonFiltrar.Clicked += new global::System.EventHandler(this.OnButtonFiltrarClicked);
			this.buttonEvento.Clicked += new global::System.EventHandler(this.OnButtonEventoClicked);
			this.buttonAdmin.Clicked += new global::System.EventHandler(this.OnButtonAdminClicked);
			this.buttonClose.Clicked += new global::System.EventHandler(this.OnButtonCloseClicked);
		}
	}
}
