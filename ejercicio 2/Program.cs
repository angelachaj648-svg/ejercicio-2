//Control de acceso a laboratorio universitario
Console.WriteLine("control de acceso");
Console.WriteLine("rol");
Console.WriteLine("1 estudiante");
Console.WriteLine("2 docente ");
Console.WriteLine("3 tecnico");
Console.WriteLine("4 visitante");
int rol = int.Parse(Console.ReadLine());
Console.WriteLine("hora 0-23");
int hora = int.Parse(Console.ReadLine());
Console.WriteLine("DIA 1=lunes a 7= domingo");
int dia  = int.Parse(Console.ReadLine());
Console.WriteLine("carnet vigente si/no");
string carnet = Console.ReadLine();
Console.WriteLine("autorizacion escrita si/no");
string autorizacion = Console.ReadLine();
Console.WriteLine("trae usb si/no");
string usb = Console.ReadLine();
string acompañado = "No";
if (usb == "si")
{
	Console.Write("esta acompado si / no ");
	acompañado = Console.ReadLine().ToUpper();
}
bool acceso = false;
string nivelPermiso = "Sin permiso";

switch (rol)
{
	case 1:
		if (carnet == "si")
		{
			if (dia >= 1 && dia <= 5 && hora >= 7 && hora <= 18)
			{
				acceso = true;
				nivelPermiso = "permiso basico estudiante";
			}
		}
		break;
	case 2:
		if (carnet == "si")
		{
			if (dia >= 1 && dia < 6 && hora >= 7 && hora <= 20)
			{
				acceso = true;
				nivelPermiso = "permiso docente";
			}
		}
		break;
	case 3:
		if (carnet == "si")
		{
			if (hora >= 0 && hora <= 23)
			{
				if (hora < 7 || hora > 20)
				{
					if (autorizacion == "si")
					{
						acceso = true;
						nivelPermiso = "permiso tecnico especial";
					}
				}
				else
				{
					acceso = true;
					nivelPermiso = "permitido tecnico normal";
				}
			}
		}
        break ;
	      case 4:


		if (autorizacion == "si")
				{
					if (acompañado == "si")
					{
						if (acompañado == "si")
						{
							acceso = true;
							nivelPermiso = "permiso visitante acompañado";
						}
					}
			break;
			
                			
			
			
					
						Console.WriteLine(" rol invalido");
			break;
				}
				if (acceso)
				{
					if (autorizacion == "si" && acompañado == "si")
					{
						acceso = true;
					}
					else
					{
						acceso = false;
						nivelPermiso = "denegado por usb sin autorizacion y acompamiento";
					}
				}
			}

					
					
    
		
					
					
				

				 
					
						





