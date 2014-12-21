﻿using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Net;
using Newtonsoft.Json;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Geometry;
using ESRI.ArcGIS.Carto;


namespace geopunt4Arcgis
{
    public class geopuntGipodCmd : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        IActiveView view;
        geopunt4arcgisExtension extension;
        gipodForm gipodFormDlg;

        public geopuntGipodCmd()
        {
            view = ArcMap.Document.ActiveView;
            extension = geopunt4arcgisExtension.getGeopuntExtension();
        }

        protected override void OnClick()
        {
            try
            {
                if (view.FocusMap.SpatialReference == null)
                {
                    MessageBox.Show("Je moet eerst een Coördinaatsysteem instellen");
                    return;
                }
                if (gipodFormDlg != null)
                {
                    if (gipodFormDlg.IsDisposed)
                    {
                        gipodFormDlg = null;
                    }
                    else
                    {
                        if (!gipodFormDlg.Visible) gipodFormDlg.Show();
                        gipodFormDlg.WindowState = FormWindowState.Normal;
                        gipodFormDlg.Focus();
                        return;
                    }
                }

                gipodFormDlg = new gipodForm();
                gipodFormDlg.Show();
                gipodFormDlg.WindowState = FormWindowState.Normal;
                gipodFormDlg.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + " : " + ex.StackTrace);
            }
        }

    }
}
