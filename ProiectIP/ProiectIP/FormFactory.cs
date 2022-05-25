/**************************************************************************
 *                                                                        *
 *  File:        FormFactory.cs                                           *
 *  Copyright:   (c) 2022, Ilie Florentin                                 *
 *  Description: Fisier cu mai multe clase, prin care se implementeaza    *
 *               design patter-ul Factory. Acesta este utilizat pentru    *
 *               a deschide o interfata noua in functie de user-ul        *
 *               care se conecteaza.                                      *
 *                                                                        *
 *  This program is free software; you can redistribute it and/or modify  *
 *  it under the terms of the GNU General Public License as published by  *
 *  the Free Software Foundation. This program is distributed in the      *
 *  hope that it will be useful, but WITHOUT ANY WARRANTY; without even   *
 *  the implied warranty of MERCHANTABILITY or FITNESS FOR A PARTICULAR   *
 *  PURPOSE. See the GNU General Public License for more details.         *
 *                                                                        *
 **************************************************************************/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProiectIP
{
    /// <summary>
    /// Clasa abstracta care are o singura metoda, CreateForm, prin care se vor creea Form-uri la runtime, in functie de tipul de utilizator care foloseste aplicatia.
    /// </summary>
    /// 
    abstract class FormFactory
    {
        public abstract Form CreateForm(Form formPrincipal,User user);
    }

    /// <summary>
    /// Clasa concreta care implementeaza metoda CreateForm din FormFactory si intoarce un form pentru utilizatorii simpli.
    /// </summary>
    class ConcreteFormIntrebari : FormFactory
    {
        public override Form CreateForm(Form formPrincipal,User user)
        {
            return new FormChestionar(formPrincipal, user);
        }
    }
    /// <summary>
    /// Clasa concreta care implementeaza metoda CreateForm din FormFactory si intoarce un form pentru utilizatorii cu drepturi de admin.
    /// </summary>
    class ConcreteFormAdmin :FormFactory
    {
        public override Form CreateForm(Form formPrincipal, User user)
        {
            return new FormAdmin(formPrincipal, user);
        }
    }
    /// <summary>
    /// Clasa care creeaza Form-ul necesar, utilizandu-se de clasele derivate din FormFactory.
    /// </summary>
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
