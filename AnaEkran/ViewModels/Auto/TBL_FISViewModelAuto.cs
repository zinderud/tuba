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
	public partial class TBL_FISViewModel  : ViewModelDetailBase< TBL_FISViewModel,TBL_FIS_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_FISViewModel () { }
TBL_FIS_MODEL model=new TBL_FIS_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_FISViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_FIS  tablosu modeli
        /// </summary>
     
        private TBL_FIS_MODEL _Propfıs;

        public TBL_FIS_MODEL Propfıs
        {
            get { return _Propfıs; }
            set { _Propfıs = value;
                NotifyPropertyChanged(m=>m.Propfıs);
                } 
        }
		 /// <summary>
        ///TBL_FIS  tablosu Secilen
        /// </summary>
     
        private TBL_FIS_MODEL _PropfısSecilen;

        public TBL_FIS_MODEL PropfısSecilen
        {
            get { return _PropfısSecilen; }
            set { _PropfısSecilen = value;
                NotifyPropertyChanged(m=>m.PropfısSecilen);
                } 
        }
        
		 /// <summary>
        ///TBL_FIS  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_FIS_MODEL> _PropfısListe;

        public ObservableCollection<TBL_FIS_MODEL> PropfısListe
        {
            get { return _PropfısListe; }
            set { _PropfısListe = value; 
                NotifyPropertyChanged(m=>m.PropfısListe);
                }
        }
         /// <summary>
        ///TBL_FIS  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_FIS_MODEL> _PropfısListeSecilen;

        public ObservableCollection<TBL_FIS_MODEL> PropfısListeSecilen
        {
            get { return _PropfısListeSecilen; }
            set { _PropfısListeSecilen = value; 
                NotifyPropertyChanged(m=>m.PropfısListeSecilen);
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_FIS_MODEL model1 = new TBL_FIS_MODEL();
              //  model1 = PropfısSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_FIS_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_FISMesaj>(new EkleTBL_FISMesaj() { MesajTBL_FIS= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_FISMesaj>(new EkleTBL_FISMesaj() { MesajTBL_FIS= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_FISMesaj>(new HataTBL_FISMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_FIS_MODEL model1 = new TBL_FIS_MODEL();
                model1 = PropfısSecilen;
                if (await serviceAgent.Sil__TBL_FIS_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_FISMesaj>(new SilTBL_FISMesaj() { MesajTBL_FIS= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_FISMesaj>(new SilTBL_FISMesaj() { MesajTBL_FIS= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_FISMesaj>(new HataTBL_FISMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_FIS_MODEL model1 = new TBL_FIS_MODEL();
                model1 = PropfısSecilen;
            if (await serviceAgent.Degistir__TBL_FIS_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_FISMesaj>(new DegistirTBL_FISMesaj() { MesajTBL_FIS= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_FISMesaj>(new DegistirTBL_FISMesaj() { MesajTBL_FIS= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_FISMesaj>(new HataTBL_FISMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                PropfısListe = await serviceAgent.Listele__TBL_FIS_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_FISMesaj>(new HataTBL_FISMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Propfıs = await serviceAgent.Bul_TBL_FIS_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_FISMesaj>(new HataTBL_FISMesaj() { Hatamesaji = ex.ToString()});


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
