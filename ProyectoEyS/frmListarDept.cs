﻿using System;
using Datos;
using Vistas;
using System.Collections.Generic;
using Gtk;

namespace ProyectoEyS
{
    public partial class frmListarDept : Gtk.Window {

        Dt_tbl_dep dtDep = new Dt_tbl_dep();
        List<Tbl_Vw_Departamento> listDep = new List<Tbl_Vw_Departamento>();
        int id=0;

        public frmListarDept() : base(Gtk.WindowType.Toplevel) {
            this.Build();
            try {
                listDep = dtDep.ColocarVwDepart();
                LlenarcbxeDepartamento();
                MostrarDatos(id);
            } catch (Exception ex) {
                CuadroMensaje("No existen datos mostrar, por favor, agregue un departamento", MessageType.Error, ButtonsType.Ok);
                this.Destroy();
            };
                
        }

        bool CuadroMensaje(string texto, MessageType typeMes, ButtonsType typeButt) {
            Gtk.MessageDialog msgEliminar;
            msgEliminar = new Gtk.MessageDialog(this, DialogFlags.DestroyWithParent, typeMes, typeButt, texto);
            ResponseType respuesta = ( ResponseType )msgEliminar.Run();
            msgEliminar.Destroy();
            return respuesta == ResponseType.Yes ? true : false;
        }

        protected void LlenarcbxeDepartamento() {
            for (int i = 0; i < listDep.Count; i++){
                this.cbxEListarDep.InsertText(i, listDep[i].Nombre);
            }
        }

        public void MostrarDatos(int id) {
            lbID.Text = listDep[id].Id.ToString();
            lbNombre.Text = listDep[id].Nombre;
            lbEmail.Text = listDep[id].Email;
            lbExt.Text = listDep[id].Ext;
            lbDescrip.Text = listDep[id].Descripcion;

            cbxEListarDep.Active = id;
            lbCountDep.Text = "" + (id + 1) + "/" + listDep.Count;
        }

        protected void OnBtnAdminDepClicked(object sender, EventArgs e) {
            frmAddDept editarDept = new frmAddDept();
            editarDept.CambiarModo(listDep[id]);
        }

        protected void OnBtnCerrarClicked(object sender, EventArgs e) {
            this.Destroy();
        }

        protected void OnCbxEListarDepChanged(object sender, EventArgs e){
            foreach (Tbl_Vw_Departamento dep in listDep) {
                if (listDep.IndexOf(dep) == cbxEListarDep.Active) {
                    id = listDep.IndexOf(dep);
                    MostrarDatos(id);        
                }
            }
        }

        protected void OnBtnAntDepClicked(object sender, EventArgs e) {
            if (id > 0) {
                id--;
                MostrarDatos(id);
            }
        }

        protected void OnBtnSigDepClicked(object sender, EventArgs e) {
            if (id < listDep.Count-1) {
                id++;
                MostrarDatos(id);
            }
        }

        protected void OnButtonCloseClicked(object sender, EventArgs e) {
            this.Destroy();
        }
    }
}