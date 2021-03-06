﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
 * Name: Shakil Hosin
 * Date: August 17th, 2017
 * Description: This is the Card Class
 * Version: 0.1 - Added the OverWrite method
 */

namespace COMP123_S2017_FinalExam_300922629
{
    public abstract class CardList : List<Card>
    {
        // PRIVATE INSTANCE VARIABLES

        // PUBLIC PROPERTIES

        // CONSTRUCTORS

        /// <summary>
        /// This is the main constructor.
        /// </summary>
        public CardList()
        {
            this._initialize();
        }

        // PRIVATE METHODS
        protected abstract void _initialize();

        // PUBLIC METHODS
    }
}