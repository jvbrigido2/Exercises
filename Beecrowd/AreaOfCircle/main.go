package main

import (
	"fmt"
	"math"
)

func main() {

	const PI = 3.14159

	var radius float64

	fmt.Scan(&radius)

	circle := PI * math.Pow(radius, 2)

	fmt.Printf("A=%.4f\n", circle)

}
