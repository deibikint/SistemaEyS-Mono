using System;
using Gtk;
using Entidades;
using Datos;
using System.Collections.Generic;
using Vistas;
using Negocio;

namespace ProyectoEyS {
    public partial class frmAddCargo : Gtk.Window {

        private int mode = 0;
        Ng_tbl_cargo ngCargo = new Ng_tbl_cargo();
        Ng_tbl_OpcRol ngOpcRol = new Ng_tbl_OpcRol();

        Dt_tbl_cargo dtCrg = new Dt_tbl_cargo();
        Dt_tbl_dep dtDept = new Dt_tbl_dep();
        Dt_tbl_horario dtHorario = new Dt_tbl_horario();

        Tbl_Cargo crg = new Tbl_Cargo();
        Tbl_Vw_Cargo crgVw = new Tbl_Vw_Cargo();
        Tbl_Usuario selectedUser;

        List<Tbl_Vw_Departamento> depList = new List<Tbl_Vw_Departamento>();
        List<Tbl_Horario> horaList;


        public frmAddCargo() :
                base(Gtk.WindowType.Toplevel) {
            this.Build();
            this.buttonEliminar.Visible = false;
            depList = dtDept.CbxDepartamentos();
            entryID.Text = (ngCargo.ContarCargos() + 1).ToString();
            entryNombre.GrabFocus();
            LlenarComboDept();
            this.Title = "Agregar Cargo";
        }

        public void CambiarModo(Tbl_Vw_Cargo crgVw) {
            mode = 1;
            Title = "Administrar Cargo";
            labelTitulo.Text = "Editar cargo";
            this.buttonEliminar.Visible = true;
            this.horaList = dtHorario.colocarHorarios(crgVw.Id);
            this.crgVw = crgVw;
            LlenarCampos();
        }

        public void ComprobarPermiso(Tbl_Usuario selectedUser) {
            if (!ngOpcRol.AccesoVentana(this.Title, selectedUser.IdRol)) {
                CuadroMensaje("No tiene permisos suficientes para acceder a esta ventana, consulte a un administrador", MessageType.Warning, ButtonsType.Ok);
                this.Destroy();
            } else
                this.selectedUser = selectedUser;
        }

        public bool Comprobaciones() {

            if (entryNombre.Text == string.Empty) {
                CuadroMensaje("Debe ingresar el nombre del cargo", MessageType.Warning, ButtonsType.Ok);
                return false;
            }

            if (cbxEDep.Active == 0) {
                CuadroMensaje("Debe seleccionar el departamento al que pertenece", MessageType.Error, ButtonsType.Ok);
                return false;
            }

            if (horaList == null) {
                CuadroMensaje("Debes establecer los horarios antes de guardar", MessageType.Error, ButtonsType.Ok);
                return false;
            }
            return true;
        }

        public void LlenarCampos() {
            entryID.Text = crgVw.Id.ToString();
            entryNombre.Text = crgVw.Nombre;
            cbxEDep.Active = EncontrarDepartamento(crgVw.Departamento) + 1;
            textvDesc.Buffer.Text = crgVw.Descripcion;
        }


        public int EncontrarDepartamento(String dep) {
            foreach (Tbl_Vw_Departamento dpt in depList)
                if (dpt.Nombre == dep)
                    return depList.IndexOf(dpt);
            return -1;
        }


        protected void LlenarComboDept() {
            int count = 0;
            cbxEDep.Clear();
            CellRendererText cell = new CellRendererText();
            cbxEDep.PackStart(cell, false);
            ListStore store = new ListStore(typeof(string));
            cbxEDep.AddAttribute(cell, "text", count);

            store.AppendValues("Sin departamento seleccionado");

            foreach (Tbl_Vw_Departamento dept in depList) {
                store.AppendValues(dept.Nombre);
                count++;
            }

            cbxEDep.Model = store;
            cbxEDep.Entry.Completion = new EntryCompletion();
            cbxEDep.Entry.Completion.Model = store;
            cbxEDep.Entry.Completion.TextColumn = 0;
            cbxEDep.Active = 0;
        }


        private Tbl_Cargo OrganizarDatos() {
            crg.Nombre = entryNombre.Text;
            crg.IdDept = ComprobarDepartamento();
            crg.Descripcion = textvDesc.Buffer.Text;

            return crg;
        }


        private int ComprobarDepartamento() {
            foreach (Tbl_Vw_Departamento dep in depList)
                if (cbxEDep.ActiveText == dep.Nombre)
                    return dep.Id;
            return -1;
        }


        bool CuadroMensaje(string texto, MessageType typeMes, ButtonsType typeButt) {
            Gtk.MessageDialog msgEliminar;
            msgEliminar = new Gtk.MessageDialog(this, DialogFlags.DestroyWithParent, typeMes, typeButt, texto);
            ResponseType respuesta = ( ResponseType )msgEliminar.Run();
            msgEliminar.Destroy();
            return respuesta == ResponseType.Yes ? true : false;
        }

        protected void OnButtonCloseClicked(object sender, EventArgs e) {
            if (CuadroMensaje("¿Quieres salir? los cambios no se guardarán", MessageType.Question, ButtonsType.YesNo))
                this.Destroy();
        }


        protected void OnButtonAdminClicked(object sender, EventArgs e) {
            int conteoError = 0;

            if (!Comprobaciones()) {
                return;
            }

            if (!CuadroMensaje("¿Deseas guardar?", MessageType.Question, ButtonsType.YesNo)) {
                return;
            }

            for (int i = 0; i < horaList.Count; i++) {
                horaList[i].IdCargo = Convert.ToInt16(entryID.Text);
            }

            if (mode == 0) {
                if (dtCrg.GuardarCargo(OrganizarDatos()))
                    CuadroMensaje("Se ha guardado con éxito", MessageType.Info, ButtonsType.Ok);
                else
                    CuadroMensaje("La operación ha fallado", MessageType.Error, ButtonsType.Ok);
                this.Destroy();

                for (int i = 0; i < horaList.Count; i++) {
                    if (dtHorario.GuardarHorario(horaList[i]))
                        conteoError++;
                }

            } else {
                crg.Estado = 2;
                if (dtCrg.EditarCargo(OrganizarDatos(), crgVw.Id))
                    CuadroMensaje("Se ha guardado con éxito", MessageType.Info, ButtonsType.Ok);
                else
                    CuadroMensaje("La operación ha fallado", MessageType.Error, ButtonsType.Ok);
                this.Destroy();

                for (int i = 0; i < horaList.Count; i++) {
                    if (!dtHorario.EditarHorario(horaList[i]))
                        conteoError++;
                }
            }
            //if (conteoError > 0) CuadroMensaje("Han ocurrido " + conteoError + " errores", MessageType.Error, ButtonsType.Ok);
            this.Destroy();
        }


        protected void OnButtonEliminarClicked(object sender, EventArgs e) {
            if (CuadroMensaje("¿Deseas eliminar este cargo?", MessageType.Question, ButtonsType.YesNo)) {
                crg.Estado = 3;
                if (dtCrg.EditarCargo(OrganizarDatos(), crgVw.Id))
                    CuadroMensaje("Se ha eliminado el cargo", MessageType.Info, ButtonsType.Ok);
                else
                    CuadroMensaje("La operación ha fallado con éxito", MessageType.Error, ButtonsType.Ok);
                this.Destroy();
            }
        }

        protected void OnButtonHorarioClicked(object sender, EventArgs e) {
            if (mode == 1) {
                frmEstablecerHorarios establecerHorarios = new frmEstablecerHorarios();
                establecerHorarios.CallAddCargo = this;
                establecerHorarios.CambiarModo(horaList);
                establecerHorarios.ComprobarPermiso(selectedUser);

            } else {
                frmEstablecerHorarios establecerHorarios = new frmEstablecerHorarios();
                establecerHorarios.CallAddCargo = this;
                establecerHorarios.ComprobarPermiso(selectedUser);

            }
        }

        public void EstablecerHorarios(List<Tbl_Horario> horaList) {
            this.horaList = horaList;

        }

    }
}