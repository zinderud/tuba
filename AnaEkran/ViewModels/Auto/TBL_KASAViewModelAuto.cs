//===================================================================================
// Sio
// Sio
//===================================================================================

#region
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using AnaEkran.Provider;
using System.Collections.ObjectModel;
using SimpleMvvmToolkit;
using AnaEkran.Models;
using ZindeMesajServisi.Messaging;
using AnaEkran.Mesaj;


#endregion

namespace AnaEkran.ViewModels
{
	public partial class TBL_KASAViewModel  : ViewModelDetailBase< TBL_KASAViewModel,TBL_KASA_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_KASAViewModel () { }
TBL_KASA_MODEL model=new TBL_KASA_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_KASAViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_KASA  tablosu modeli
        /// </summary>
     
        private TBL_KASA_MODEL _Propkasa;

        public TBL_KASA_MODEL Propkasa
        {
            get { return _Propkasa; }
            set { _Propkasa = value;
                NotifyPropertyChanged(m=>m.Propkasa);
                } 
        }
		 /// <summary>
        ///TBL_KASA  tablosu Secilen
        /// </summary>
     
        private TBL_KASA_MODEL _PropkasaSecilen;

        public TBL_KASA_MODEL PropkasaSecilen
        {
            get { return _PropkasaSecilen; }
            set { _PropkasaSecilen = value;
                NotifyPropertyChanged(m=>m.PropkasaSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_KASA  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_KASA_MODEL> _PropkasaListe;

        public ObservableCollection<TBL_KASA_MODEL> PropkasaListe
        {
            get { return _PropkasaListe; }
            set { _PropkasaListe = value; 
                NotifyPropertyChanged(m=>m.PropkasaListe);
                }
        }
         /// <summary>
        ///TBL_KASA  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_KASA_MODEL> _PropkasaListeSecilen;

        public ObservableCollection<TBL_KASA_MODEL> PropkasaListeSecilen
        {
            get { return _PropkasaListeSecilen; }
            set { _PropkasaListeSecilen = value; 
                NotifyPropertyChanged(m=>m.PropkasaListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_KASA_MODEL model1 = new TBL_KASA_MODEL();
              //  model1 = PropkasaSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_KASA_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_KASAMesaj>(new EkleTBL_KASAMesaj() { MesajTBL_KASA= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_KASAMesaj>(new EkleTBL_KASAMesaj() { MesajTBL_KASA= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_KASAMesaj>(new HataTBL_KASAMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_KASA_MODEL model1 = new TBL_KASA_MODEL();
                model1 = PropkasaSecilen;
                if (await serviceAgent.Sil__TBL_KASA_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_KASAMesaj>(new SilTBL_KASAMesaj() { MesajTBL_KASA= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_KASAMesaj>(new SilTBL_KASAMesaj() { MesajTBL_KASA= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_KASAMesaj>(new HataTBL_KASAMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_KASA_MODEL model1 = new TBL_KASA_MODEL();
                model1 = PropkasaSecilen;
            if (await serviceAgent.Degistir__TBL_KASA_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_KASAMesaj>(new DegistirTBL_KASAMesaj() { MesajTBL_KASA= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_KASAMesaj>(new DegistirTBL_KASAMesaj() { MesajTBL_KASA= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_KASAMesaj>(new HataTBL_KASAMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                PropkasaListe = await serviceAgent.Listele__TBL_KASA_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_KASAMesaj>(new HataTBL_KASAMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propkasa = await serviceAgent.Bul_TBL_KASA_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_KASAMesaj>(new HataTBL_KASAMesaj() { Hatamesaji = ex.ToString()});


             }
        }
        
        #endregion
		#region komut
	 public ICommand EkleCommand
        {
            get
            {
                return new DelegateCommand(Ekle);
            }
        }
		 public ICommand SiCommand
        {
            get
            {
                return new DelegateCommand(Sil);
            }
        }
		 public ICommand DegistirCommand
        {
            get
            {
                return new DelegateCommand(Degistir);
            }
        }
		 public ICommand ListeleCommand
        {
            get
            {
                return new DelegateCommand(Listele);
            }
        }
		 public ICommand BulCommand
        {
            get
            {
                return new DelegateCommand<int>(Bul);
            }
        }
	   #endregion

        
         
	}
}
