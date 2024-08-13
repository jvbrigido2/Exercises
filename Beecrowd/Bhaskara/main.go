package main

import (
	"fmt"
	"math"
)

func main() {

	var A, B, C float64

	fmt.Scanf("%f %f %f", &A, &B, &C)

	delta := math.Pow(B, 2) - 4*A*C

	if delta < 0 || A == 0 {
		fmt.Println("Impossivel calcular")
		return
	}
	sqrtDelta := math.Sqrt(delta)

	R1 := (-B + sqrtDelta) / (2 * A)
	R2 := (-B - sqrtDelta) / (2 * A)

	fmt.Printf("R1 = %.5f\n", R1)
	fmt.Printf("R2 = %.5f\n", R2)

}
