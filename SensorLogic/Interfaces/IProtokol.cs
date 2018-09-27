using System;

namespace SensorLogic.Interfaces
{
   public interface IProtokol
   {
       void ProtokollAlert(DateTime date,string message);
   }
}
