package testdata

import (
	"sync/atomic"
)

type Counter uint64

func AtomicTests() {
	x := uint64(1)
	x = atomic.AddUint64(&x, 1)        // ERROR "direct assignment to atomic value"
	_, x = 10, atomic.AddUint64(&x, 1) // ERROR "direct assignment to atomic value"
	x, _ = atomic.AddUint64(&x, 1), 10 // ERROR "direct assignment to atomic value"

	y := &x
}