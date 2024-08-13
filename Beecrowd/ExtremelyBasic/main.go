package main

import "fmt"

func main() {

	var firstNumber int
	var secondNumber int

	fmt.Scan(&firstNumber)
	fmt.Scan(&secondNumber)

	soma := firstNumber + secondNumber

	fmt.Printf("X = %d", soma)

}
