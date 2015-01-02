using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace People2Orgs
{
    [Activity(Label = "Envía tu retroalimentación!")]
    public class RetroalimentacionActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Create your application here.
            SetContentView(Resource.Layout.Retroalimentacion);

            int calificacionActual;
            
            TextView tvCalificacion = FindViewById<TextView>(Resource.Id.calificacion);
            

            ImageButton sumarCalificacion = FindViewById<ImageButton>(Resource.Id.ibAumentar);
            sumarCalificacion.Click += (sender, e) =>
            {
                calificacionActual = Convert.ToInt16(tvCalificacion.Text);
                calificacionActual = calificacionActual + 10;
                tvCalificacion.Text = calificacionActual.ToString();
                ActualizarImagenEmocion(calificacionActual);
            };

            ImageButton restarCalificacion = FindViewById<ImageButton>(Resource.Id.ibRestar);
            restarCalificacion.Click += (sender, e) =>
            {
                //TextView tvCalificacion = FindViewById<TextView>(Resource.Id.calificacion);
                //calificacionActual = Convert.ToInt16(tvCalificacion.Text);
                calificacionActual = Convert.ToInt16(tvCalificacion.Text);
                calificacionActual = calificacionActual - 10;
                tvCalificacion.Text = calificacionActual.ToString();
                ActualizarImagenEmocion(calificacionActual);
            };

        }

        void ActualizarImagenEmocion(int nivelEmocion)
        {
            ImageButton ibEmocion;
            ibEmocion = FindViewById<ImageButton>(Resource.Id.imgExpresion);

            switch (nivelEmocion)
            {
                    
                case 10:
                    ibEmocion.SetImageResource(Resource.Drawable.C10);
                    break;
                case 20:
                    //ibEmocion = FindViewById<ImageButton>(Resource.Id.imgExpresion);
                    ibEmocion.SetImageResource(Resource.Drawable.C25);
                    break;
                case 30:
                    //ibEmocion = FindViewById<ImageButton>(Resource.Id.imgExpresion);
                    ibEmocion.SetImageResource(Resource.Drawable.C25);
                    break;
                case 40:
                    //ibEmocion = FindViewById<ImageButton>(Resource.Id.imgExpresion);
                    ibEmocion.SetImageResource(Resource.Drawable.C50);
                    break;
                case 50:
                    //ibEmocion = FindViewById<ImageButton>(Resource.Id.imgExpresion);
                    ibEmocion.SetImageResource(Resource.Drawable.C50);
                    break;
                case 60:
                    //ibEmocion = FindViewById<ImageButton>(Resource.Id.imgExpresion);
                    ibEmocion.SetImageResource(Resource.Drawable.C80);
                    break;
                case 70:
                    //ibEmocion = FindViewById<ImageButton>(Resource.Id.imgExpresion);
                    ibEmocion.SetImageResource(Resource.Drawable.C80);
                    break;
                case 90:
                    //ibEmocion = FindViewById<ImageButton>(Resource.Id.imgExpresion);
                    ibEmocion.SetImageResource(Resource.Drawable.C90);
                    break;
                case 100:
                    //ibEmocion = FindViewById<ImageButton>(Resource.Id.imgExpresion);
                    ibEmocion.SetImageResource(Resource.Drawable.C100);
                    break;
                default:
                    break;
            }
        }
    }
}