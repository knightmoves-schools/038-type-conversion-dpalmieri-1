namespace knightmoves;

public class Converter{
   //Add your code here
   public decimal ConvertImplicitly(int Number){
      decimal Value = Number;
      return Value;
   }
   public int ConvertExplicitly(decimal Doubler){
      int Converted = Convert.ToInt32(Doubler);
      return Converted;
   }
}






