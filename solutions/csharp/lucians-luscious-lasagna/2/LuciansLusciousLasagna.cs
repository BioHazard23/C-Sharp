class Lasagna
{
    // Devuelve el tiempo esperado en el horno (40 minutos)
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // Calcula el tiempo restante en el horno
    public int RemainingMinutesInOven(int actualMinutes)
    {
        return ExpectedMinutesInOven() - actualMinutes;
    }

    // Calcula el tiempo de preparación
    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    // Calcula el tiempo total transcurrido (preparación + horno)
    public int ElapsedTimeInMinutes(int layers, int actualMinutes)
    {
        return PreparationTimeInMinutes(layers) + actualMinutes;
    }
}