using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Singleton_pattern
{
    class singleton
    {
        singleton obj;
        public static singleton SING
     
        {
            get (if obj==null)
        {
            obj = new singleton();
            return obj;
        }
            else 
            return obj;

        }

         public string Test()
{
    return "singleton pattern executed";
}   
                
                
       
    }
   
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show(singleton.SING.Test());
        }
    }
}
