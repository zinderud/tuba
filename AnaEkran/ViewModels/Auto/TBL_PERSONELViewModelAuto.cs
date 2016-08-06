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
using System.Windows.Forms;
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
	public partial class TBL_PERSONELViewModel  : ViewModelDetailBase< TBL_PERSONELViewModel,TBL_PERSONEL_MODEL> 
    {
	 #region Initialization and Cleanup
        private IProvider serviceAgent;
		// Default ctor
        public TBL_PERSONELViewModel () { }
TBL_PERSONEL_MODEL model=new TBL_PERSONEL_MODEL();
        // Ctor that accepts ICustomerServiceAgent
        public TBL_PERSONELViewModel (IProvider serviceAgent)
        {
            base.Model = model;

            this.serviceAgent = serviceAgent;
            Baslangic();
        }
		 #endregion
		
	 
         #region Properties
		 /// <summary>
        ///TBL_PERSONEL  tablosu modeli
        /// </summary>
     
        private TBL_PERSONEL_MODEL _Proppersonel;

        public TBL_PERSONEL_MODEL Proppersonel
        {
            get { return _Proppersonel; }
            set { _Proppersonel = value;
                NotifyPropertyChanged(m=>m.Proppersonel);
                } 
        }
		 /// <summary>
        ///TBL_PERSONEL  tablosu Secilen
        /// </summary>
     
        private TBL_PERSONEL_MODEL _ProppersonelSecilen;

        public TBL_PERSONEL_MODEL ProppersonelSecilen
        {
            get { return _ProppersonelSecilen; }
            set { _ProppersonelSecilen = value;
                NotifyPropertyChanged(m=>m.ProppersonelSecilen);
                try
                {
                    this.model.YETKI_SEVIYESI = ProppersonelSecilen.YETKI_SEVIYESI;
                }
                catch (Exception)
                {

                    MessageBox.Show("Yetki Seviyesi Eklenemedi");
                }
               
            } 
        }
        
		 /// <summary>
        ///TBL_PERSONEL  tablosu Listesi modeli
        /// </summary>
      
        private ObservableCollection<TBL_PERSONEL_MODEL> _ProppersonelListe;

        public ObservableCollection<TBL_PERSONEL_MODEL> ProppersonelListe
        {
            get { return _ProppersonelListe; }
            set { _ProppersonelListe = value; 
                NotifyPropertyChanged(m=>m.ProppersonelListe);
                     
                }
        }
         /// <summary>
        ///TBL_PERSONEL  tablosu Listesi secilen modeli
        /// </summary>
      
        private ObservableCollection<TBL_PERSONEL_MODEL> _ProppersonelListeSecilen;

        public ObservableCollection<TBL_PERSONEL_MODEL> ProppersonelListeSecilen
        {
            get { return _ProppersonelListeSecilen; }
            set { _ProppersonelListeSecilen = value; 
                NotifyPropertyChanged(m=>m.ProppersonelListeSecilen);
         
                }
        }
        
        
        
        #endregion
         
        
		  #region Methods

      

        public async void Ekle()
        {
            try
            {
                TBL_PERSONEL_MODEL model1 = new TBL_PERSONEL_MODEL();
              //  model1 = ProppersonelSecilen;
                 model1=this.Model;
                if (await serviceAgent.Ekle__TBL_PERSONEL_MODEL(model1))
                {
                       Listele();
                    Messenger.Default.Send<EkleTBL_PERSONELMesaj>(new EkleTBL_PERSONELMesaj() { MesajTBL_PERSONEL= model1,mesaj = "Eklendi"});
                 
                }
                else
                {
                 Messenger.Default.Send<EkleTBL_PERSONELMesaj>(new EkleTBL_PERSONELMesaj() { MesajTBL_PERSONEL= model1,mesaj = "Eklendi bilinmeyen hata"});

                }
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_PERSONELMesaj>(new HataTBL_PERSONELMesaj() { Hatamesaji =ex.ToString()});
                
            }
            
        }
        public async void Sil()
        {
            try
            {
               TBL_PERSONEL_MODEL model1 = new TBL_PERSONEL_MODEL();
                model1 = ProppersonelSecilen;
                if (await serviceAgent.Sil__TBL_PERSONEL_MODEL(model1))
                {
                    Listele();
                  Messenger.Default.Send<SilTBL_PERSONELMesaj>(new SilTBL_PERSONELMesaj() { MesajTBL_PERSONEL= model1,mesaj = "Silindi"});
                
                }
                else
                {
                  Messenger.Default.Send<SilTBL_PERSONELMesaj>(new SilTBL_PERSONELMesaj() { MesajTBL_PERSONEL= model1,mesaj = "Silindi Bilinmeyen hata"});
                }
            }
            catch (Exception ex)
            {
                  Messenger.Default.Send<HataTBL_PERSONELMesaj>(new HataTBL_PERSONELMesaj() { Hatamesaji = ex.ToString()});
               
            }
           
        }
        public async void Degistir()
        {
             try
            {
                TBL_PERSONEL_MODEL model1 = new TBL_PERSONEL_MODEL();
                model1 = ProppersonelSecilen;
            if (await serviceAgent.Degistir__TBL_PERSONEL_MODEL(model1))
            {   Listele();
                 Messenger.Default.Send<DegistirTBL_PERSONELMesaj>(new DegistirTBL_PERSONELMesaj() { MesajTBL_PERSONEL= model1,mesaj = "Degistirildi"});
              
                }
            else
            {
                  Messenger.Default.Send<DegistirTBL_PERSONELMesaj>(new DegistirTBL_PERSONELMesaj() { MesajTBL_PERSONEL= model1,mesaj = "Degistir Bilinmeyen hata"});
            }
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_PERSONELMesaj>(new HataTBL_PERSONELMesaj() { Hatamesaji = ex.ToString()});

             }
        }
        public async void Listele()
        {
            try
            {
                ProppersonelListe = await serviceAgent.Listele__TBL_PERSONEL_MODEL();
            }
            catch (Exception ex)
            {
                Messenger.Default.Send<HataTBL_PERSONELMesaj>(new HataTBL_PERSONELMesaj() { Hatamesaji = ex.ToString()});

              
            }
           
        }
        public async void Bul(int id)
        {
             try
            {
              Proppersonel = await serviceAgent.Bul_TBL_PERSONEL_MODEL(id);
            }
             catch (Exception ex)
             {
                 Messenger.Default.Send<HataTBL_PERSONELMesaj>(new HataTBL_PERSONELMesaj() { Hatamesaji = ex.ToString()});


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
