using ISKI.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities;

public class DigitalSensorData : BaseEntity<int>
{
    public DateTime ReadTime { get; set; }
    public bool Kapi { get; set; }
    public bool Duman { get; set; }
    public bool SuBaskini { get; set; }
    public bool AcilStop { get; set; }
    public bool Pompa1Termik { get; set; }
    public bool Pompa2Termik { get; set; }
    public bool TemizSuTermik { get; set; }
    public bool YikamaTanki { get; set; }
    public bool Enerji { get; set; }
    public bool Pompa1CalisiyorMu { get; set; }
    public bool Pompa2CalisiyorMu { get; set; }
}
