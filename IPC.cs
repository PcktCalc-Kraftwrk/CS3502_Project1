
// C# program to illustrate the 
// Console.In Property 
using System; 
using System.Collections.Generic; 
using System.Linq; 
using System.Text; 
using System.Threading.Tasks; 
  
namespace GFG { 
  
class Program { 
  
    static void Main(string[] args) 
    { 
  		Console.WriteLine("Standard Input Stream");
        // Get the Standard Input Stream 
        Console.WriteLine("Standard Input Stream: {0}", 
                                          Console.In); 
    }  
} 
	public abstract class NamedPipeBase<T> : IPCConnection
        where T : PipeStream
{
   protected readonly string _name;
   protected T Pipe;
   private StreamString _stream;

   public NamedPipeBase(string pipeName)
   {
      _name = pipeName;
   }

   public event EventHandler Disconnected;
   private void OnDisconnected()
   {
      Disconnected?.Invoke(this, EventArgs.Empty);
   }

   public event EventHandler<MessageReceivedEventArgs> MessageReceived;
   private void OnMessageReceived(string message)
   {
      MessageReceived?.Invoke(this, new MessageReceivedEventArgs(message));
   }

   protected void Initialize(T pipeStream)
   {
      Pipe = pipeStream;
      _stream = new StreamString(pipeStream);
   }

   protected async Task StartReading()
   {
      await Task.Factory.StartNew(async () =>
      {
         try
         {
            while (true)
            {
               var message = await _stream.ReadString();
               OnMessageReceived(message);
            }
         }
         catch (InvalidOperationException)
         {
            OnDisconnected();
            Dispose();
         }
      });
   }

   public async Task Send(string message)
   {
      await _stream.WriteString(message);
   }

   public abstract void Dispose();
}
} 
