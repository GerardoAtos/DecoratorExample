

using DecoratorExample;

PowerRanger red = new PowerRanger(1,"Tommy","Morphing");


IPowerRanger ranger1 = new RangerRojo();
ranger1.Transformacion(red);

IPowerRanger rangerRojoPoder = new PoderDecorator(ranger1);
rangerRojoPoder.Transformacion(red);

IPowerRanger rangerRojoespada = new EspadaDecorator(ranger1);
rangerRojoespada.Transformacion(red);

//((PowerRanger)rangerRojoespada)




