using System;

public class Class1
{
	public Class1()
	{

        public static void main(String[] args) throws IOException {
            // TODO code application logic here

            String palabra;
            ListaCircular listaCp;
            int opc;
            BufferedReader entrada = new BufferedReader(
                    new InputStreamReader(System.in));
            listaCp = new ListaCircular();
            Console.WriteLine("\n Digite nombres. \nTermina con FIN.");
            palabra = "";

            while (!(palabra = entrada.readLine()).equals("FIN"))
            {
                String nueva;
                nueva = new String(palabra);
                listaCp.insertar(nueva);
            }
            Console.WriteLine("\t\tLista circular de palabras");
            listaCp.recorrer();
            Console.WriteLine("\n\t Opciones para manejar la lista");
            do
            {
                Console.WriteLine("1. Eliminar una palabra.\n");
                Console.WriteLine("2. Mostrar la lista completa.\n");
                Console.WriteLine("3. Salir y eliminar la lista.\n");
                do
                {
                    opc = Integer.parseInt(entrada.readLine());
                } while (opc < 1 || opc > 3);
                switch (opc)
                {
                    case 1:
                        Console.WriteLine("Palabra a eliminar: ");
                        palabra = entrada.readLine();
                        listaCp.eliminar(palabra);
                        break;
                    case 2:
                        Console.WriteLine("Palabras en la Lista:\n");
                        listaCp.recorrer();
                        break;
                    case 3:
                        Console.WriteLine("Eliminación de la lista.");
                        listaCp.borrarLista();
                }
            } while (opc != 3);
        }

    }
}
