﻿//  _    _ _    ___    _  ___ _ _   _        
// | |  (_) |__| _ \_ | |/ __(_) |_(_)___ ___
// | |__| | '_ \   / || | (__| |  _| / -_|_-<
// |____|_|_.__/_|_\\__(_)___|_|\__|_\___/__/
//
// Author(s):
//   Arthur Lucas <arthur@remitjet.com>
//
// Copyright (c) 2015 Remit Jet, Ltd.
//
// By using this software you agree to our software license as detailed in the
// LICENSE.txt file in the root of the repository.  You can also view this file
// online at: https://github.com/RemitJet/LibRJ.Cities/blob/master/LICENSE.txt
//
using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

namespace LibRJ.Cities.Models
{
    public class Region : GeoNameResource
    {
        public int ID { get; set; }

        [StringLength(200)]
        public string Name { get; set; }

        public int CountryID { get; set; }
        public ICollection<City> Cities { get; set; }
    }
}
