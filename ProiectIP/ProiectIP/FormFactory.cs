using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectIP
{
    abstract class FormFactory
    {
        public abstract Form CreateForm(Form formPrincipal,User user);
    }

    class ConcreteFormIntrebari : FormFactory
    {
        public override Form CreateForm(Form formPrincipal,User user)
        {
            return new FormChestionar(formPrincipal, user);
        }
    }

    class ConcreteFormAdmin:FormFactory
    {
        public override Form CreateForm(Form formPrincipal, User user)
        {
            return new FormAdmin(formPrincipal, user);
        }
    }

    public class FormCreator
    {
        public static Form CreateForm(Form formPrincipal,User user)
        {
            FormFactory factory;
            if(user.GetIsAdmin)
            {
                factory = new ConcreteFormAdmin();
            }
            else
            {
                factory = new ConcreteFormIntrebari();
            }
            return factory.CreateForm(formPrincipal, user);
        }
    }

}
