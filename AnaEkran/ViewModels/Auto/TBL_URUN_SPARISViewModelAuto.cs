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
	public partial class TBL_URUN_SPARISViewModel  : ViewModelDetailBase< TBL_URUN_SPARISViewModel,TBL_URUN_SPARIS_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_URUN_SPARISViewModel () { }
TBL_URUN_SPARIS_MODEL model=new TBL_URUN_SPARIS_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_URUN_SPARISViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_URUN_SPARIS  tablosu modeli
        /// </summary>
     
        private TBL_URUN_SPARIS_MODEL _Propurun_sparıs;

        public TBL_URUN_SPARIS_MODEL Propurun_sparıs
        {
            get { return _Propurun_sparıs; }
            set { _Propurun_sparıs = value;
                NotifyPropertyChanged(m=>m.Propurun_sparıs);
                } 
        }
		 /// <summary>
        ///TBL_URUN_SPARIS  tablosu Secilen
        /// </summary>
     
        private TBL_URUN_SPARIS_MODEL _Propurun_sparısSecilen;

        public TBL_URUN_SPARIS_MODEL Propurun_sparısSecilen
        {
            get { return _Propurun_sparısSecilen; }
            set { _Propurun_sparısSecilen = value;
                NotifyPropertyChanged(m=>m.Propurun_sparısSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_URUN_SPARIS  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_URUN_SPARIS_MODEL> _Propurun_sparısListe;

        public ObservableCollection<TBL_URUN_SPARIS_MODEL> Propurun_sparısListe
        {
            get { return _Propurun_sparısListe; }
            set { _Propurun_sparısListe = value; 
                NotifyPropertyChanged(m=>m.Propurun_sparısListe);
                }
        }
         /// <summary>
        ///TBL_URUN_SPARIS  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_URUN_SPARIS_MODEL> _Propurun_sparısListeSecilen;

        public ObservableCollection<TBL_URUN_SPARIS_MODEL> Propurun_sparısListeSecilen
        {
            get { return _Propurun_sparısListeSecilen; }
            set { _Propurun_sparısListeSecilen = value; 
                NotifyPropertyChanged(m=>m.Propurun_sparısListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_URUN_SPARIS_MODEL model1 = new TBL_URUN_SPARIS_MODEL();
              //  model1 = Propurun_sparısSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_URUN_SPARIS_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_URUN_SPARISMesaj>(new EkleTBL_URUN_SPARISMesaj() { MesajTBL_URUN_SPARIS= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_URUN_SPARISMesaj>(new EkleTBL_URUN_SPARISMesaj() { MesajTBL_URUN_SPARIS= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_URUN_SPARISMesaj>(new HataTBL_URUN_SPARISMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_URUN_SPARIS_MODEL model1 = new TBL_URUN_SPARIS_MODEL();
                model1 = Propurun_sparısSecilen;
                if (await serviceAgent.Sil__TBL_URUN_SPARIS_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_URUN_SPARISMesaj>(new SilTBL_URUN_SPARISMesaj() { MesajTBL_URUN_SPARIS= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_URUN_SPARISMesaj>(new SilTBL_URUN_SPARISMesaj() { MesajTBL_URUN_SPARIS= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_URUN_SPARISMesaj>(new HataTBL_URUN_SPARISMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_URUN_SPARIS_MODEL model1 = new TBL_URUN_SPARIS_MODEL();
                model1 = Propurun_sparısSecilen;
            if (await serviceAgent.Degistir__TBL_URUN_SPARIS_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_URUN_SPARISMesaj>(new DegistirTBL_URUN_SPARISMesaj() { MesajTBL_URUN_SPARIS= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_URUN_SPARISMesaj>(new DegistirTBL_URUN_SPARISMesaj() { MesajTBL_URUN_SPARIS= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_URUN_SPARISMesaj>(new HataTBL_URUN_SPARISMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                Propurun_sparısListe = await serviceAgent.Listele__TBL_URUN_SPARIS_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_URUN_SPARISMesaj>(new HataTBL_URUN_SPARISMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propurun_sparıs = await serviceAgent.Bul_TBL_URUN_SPARIS_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_URUN_SPARISMesaj>(new HataTBL_URUN_SPARISMesaj() { Hatamesaji = ex.ToString()});


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
