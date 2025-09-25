class Lasagna
{
    // Método que devuelve el tiempo esperado en el horno (40 minutos)
    public int ExpectedMinutesInOven()
    {
        return 40;
    }

    // Método que calcula el tiempo restante en el horno
    public int RemainingMinutesInOven(int actualMinutes)
    {
        return ExpectedMinutesInOven() - actualMinutes;
    }

    // Método que calcula el tiempo de preparación
    public int PreparationTimeInMinutes(int layers)
    {
        return layers * 2;
    }

    // Método que calcula el tiempo total transcurrido (preparación + horno)
    public int ElapsedTimeInMinutes(int layers, int actualMinutes)
    {
        return PreparationTimeInMinutes(layers) + actualMinutes;
    }
}