using System;

class euler {
  public double factorial(double end) {
    double factorialResult = 1.0;
    for (int i = 1; i <= end; i++) {
      factorialResult *= i;
    }
    return factorialResult;
  }

  public double getE(int termCount) {
    double e = 1.0;
    for (double i = 1; i <= termCount; i++) {
      e += (1.0/factorial(i));
    }
    return e;
  }
}