namespace Bridge
{
  internal class Program
  {
    static void Main()
    {
      
      IShapeRenderer vectorRenderer = new VectorRenderer();
      IShapeRenderer rasterRenderer = new RasterRenderer();

      
      Shape vectorCircle = new Circle(vectorRenderer);
      Shape rasterSquare = new Square(rasterRenderer);
      Shape vectorTriangle = new Triangle(vectorRenderer);

      
      vectorCircle.Draw();   
      rasterSquare.Draw();   
      vectorTriangle.Draw(); 
    }
  }
}
