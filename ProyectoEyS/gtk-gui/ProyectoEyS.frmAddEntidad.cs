
// This file has been generated by the GUI designer. Do not modify.
namespace ProyectoEyS
{
	public partial class frmAddEntidad
	{
		private global::Gtk.VBox vbox1;

		private global::Gtk.Label labelTitulo;

		private global::Gtk.Label labelSubTitulo;

		private global::Gtk.HBox hbox8;

		private global::Gtk.VSeparator vseparator2;

		private global::Gtk.HBox hbox9;

		private global::Gtk.ComboBoxEntry cboxEntidad;

		private global::Gtk.VSeparator vseparator1;

		private global::Gtk.HSeparator hseparator1;

		private global::Gtk.HButtonBox hbuttonbox6;

		private global::Gtk.Button aceptar;

		private global::Gtk.Button cerrar;

		protected virtual void Build()
		{
			global::Stetic.Gui.Initialize(this);
			// Widget ProyectoEyS.frmAddEntidad
			this.WidthRequest = 380;
			this.Name = "ProyectoEyS.frmAddEntidad";
			this.Title = global::Mono.Unix.Catalog.GetString("frmAddEntidad");
			this.WindowPosition = ((global::Gtk.WindowPosition)(4));
			this.Resizable = false;
			// Container child ProyectoEyS.frmAddEntidad.Gtk.Container+ContainerChild
			this.vbox1 = new global::Gtk.VBox();
			this.vbox1.Name = "vbox1";
			this.vbox1.Spacing = 6;
			// Container child vbox1.Gtk.Box+BoxChild
			this.labelTitulo = new global::Gtk.Label();
			this.labelTitulo.HeightRequest = 40;
			this.labelTitulo.Name = "labelTitulo";
			this.labelTitulo.Xalign = 0.03F;
			this.labelTitulo.Yalign = 0.77F;
			this.labelTitulo.LabelProp = global::Mono.Unix.Catalog.GetString("Añadir/Listar entidad");
			this.vbox1.Add(this.labelTitulo);
			global::Gtk.Box.BoxChild w1 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelTitulo]));
			w1.Position = 0;
			w1.Expand = false;
			w1.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.labelSubTitulo = new global::Gtk.Label();
			this.labelSubTitulo.HeightRequest = 32;
			this.labelSubTitulo.Name = "labelSubTitulo";
			this.labelSubTitulo.Xalign = 0.1F;
			this.labelSubTitulo.LabelProp = global::Mono.Unix.Catalog.GetString("Seleccione la entidad a agregar:");
			this.vbox1.Add(this.labelSubTitulo);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.labelSubTitulo]));
			w2.Position = 1;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbox8 = new global::Gtk.HBox();
			this.hbox8.Name = "hbox8";
			this.hbox8.Spacing = 6;
			// Container child hbox8.Gtk.Box+BoxChild
			this.vseparator2 = new global::Gtk.VSeparator();
			this.vseparator2.WidthRequest = 18;
			this.vseparator2.Name = "vseparator2";
			this.hbox8.Add(this.vseparator2);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.vseparator2]));
			w3.Position = 0;
			w3.Expand = false;
			w3.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.hbox9 = new global::Gtk.HBox();
			this.hbox9.Name = "hbox9";
			this.hbox9.Spacing = 6;
			// Container child hbox9.Gtk.Box+BoxChild
			this.cboxEntidad = global::Gtk.ComboBoxEntry.NewText();
			this.cboxEntidad.AppendText(global::Mono.Unix.Catalog.GetString("Empleado"));
			this.cboxEntidad.AppendText(global::Mono.Unix.Catalog.GetString("Departamento"));
			this.cboxEntidad.AppendText(global::Mono.Unix.Catalog.GetString("Cargo"));
			this.cboxEntidad.WidthRequest = 257;
			this.cboxEntidad.Name = "cboxEntidad";
			this.cboxEntidad.Active = 0;
			this.hbox9.Add(this.cboxEntidad);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.hbox9[this.cboxEntidad]));
			w4.Position = 0;
			w4.Expand = false;
			w4.Fill = false;
			this.hbox8.Add(this.hbox9);
			global::Gtk.Box.BoxChild w5 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.hbox9]));
			w5.Position = 1;
			w5.Expand = false;
			w5.Fill = false;
			// Container child hbox8.Gtk.Box+BoxChild
			this.vseparator1 = new global::Gtk.VSeparator();
			this.vseparator1.WidthRequest = 18;
			this.vseparator1.Name = "vseparator1";
			this.hbox8.Add(this.vseparator1);
			global::Gtk.Box.BoxChild w6 = ((global::Gtk.Box.BoxChild)(this.hbox8[this.vseparator1]));
			w6.Position = 2;
			w6.Expand = false;
			w6.Fill = false;
			this.vbox1.Add(this.hbox8);
			global::Gtk.Box.BoxChild w7 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbox8]));
			w7.Position = 2;
			w7.Expand = false;
			w7.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hseparator1 = new global::Gtk.HSeparator();
			this.hseparator1.HeightRequest = 20;
			this.hseparator1.Name = "hseparator1";
			this.vbox1.Add(this.hseparator1);
			global::Gtk.Box.BoxChild w8 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hseparator1]));
			w8.Position = 3;
			w8.Expand = false;
			w8.Fill = false;
			// Container child vbox1.Gtk.Box+BoxChild
			this.hbuttonbox6 = new global::Gtk.HButtonBox();
			this.hbuttonbox6.HeightRequest = 75;
			this.hbuttonbox6.Name = "hbuttonbox6";
			this.hbuttonbox6.Spacing = 4;
			this.hbuttonbox6.BorderWidth = ((uint)(10));
			this.hbuttonbox6.LayoutStyle = ((global::Gtk.ButtonBoxStyle)(4));
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.aceptar = new global::Gtk.Button();
			this.aceptar.HeightRequest = 60;
			this.aceptar.CanFocus = true;
			this.aceptar.Name = "aceptar";
			this.aceptar.UseUnderline = true;
			this.aceptar.Label = global::Mono.Unix.Catalog.GetString("Aceptar");
			this.hbuttonbox6.Add(this.aceptar);
			global::Gtk.ButtonBox.ButtonBoxChild w9 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.aceptar]));
			w9.Expand = false;
			w9.Fill = false;
			// Container child hbuttonbox6.Gtk.ButtonBox+ButtonBoxChild
			this.cerrar = new global::Gtk.Button();
			this.cerrar.CanFocus = true;
			this.cerrar.Name = "cerrar";
			this.cerrar.UseUnderline = true;
			this.cerrar.Label = global::Mono.Unix.Catalog.GetString("Cerrar");
			this.hbuttonbox6.Add(this.cerrar);
			global::Gtk.ButtonBox.ButtonBoxChild w10 = ((global::Gtk.ButtonBox.ButtonBoxChild)(this.hbuttonbox6[this.cerrar]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			this.vbox1.Add(this.hbuttonbox6);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox1[this.hbuttonbox6]));
			w11.Position = 4;
			w11.Expand = false;
			w11.Fill = false;
			this.Add(this.vbox1);
			if ((this.Child != null))
			{
				this.Child.ShowAll();
			}
			this.DefaultWidth = 380;
			this.DefaultHeight = 225;
			this.Show();
			this.aceptar.Clicked += new global::System.EventHandler(this.OnAceptarClicked);
			this.cerrar.Clicked += new global::System.EventHandler(this.OnCerrarClicked);
		}
	}
}
