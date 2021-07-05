public class DynamicNumberArray{

    int[] buffer;
    public DynamicArray(){ buffer=new int[5];
    public DynamicArray(int initialSize){ buffer=new int[initialSize];}
    
    public void Set(int index,int value){
        
        buffer[index]=value;
    }
    public int Get(int index){
    return buffer[index];   
    }
    
 }
 
 public class Program{
  static void Main(){
      DynamicNumberArray _dynamic=new DynamicNumberArray();
      _dynamic[0]=10;
      _dynamic[1]=20;
      _dynamic[2]=30;
      _dynamic[3]=40;
      _dynamic[4]=50;
      _dynamic[5]=60;
      
      int value=_dynamic[5];
      Console.WriteLine(value);
  }
 }
