﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SearchAlgorithms
{
    internal class LinearSearch
    {
        public static int  Perform (double searchValue, List<double> listToSearch) 
        {
            for (int i = 0; i < listToSearch.Count; i++)
            {

                if (listToSearch[i] == searchValue)

                    return i;
            }
        
        
        }
}
