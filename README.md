# Design-Patterns-Head-First

## Strategy Pattern:

The Strategy Pattern defines a family of algorithms,
encapsulates each one, and makes them interchangeable.
Strategy lets the algorithm vary independently from
clients that use it.

Just aas we did with the fly behavior and quack behavior..

They are now indeed interchangeable, we took the behavior that varied and encapsulated it.

Notice also that we’ve started to describe things a little differently. Instead
of thinking of the duck behaviors as a set of behaviors, we’ll start thinking of
them as a family of algorithms. Think about it: in the SimUDuck design, the
algorithms represent things a duck would do (different ways of quacking or
flying), but we could just as easily use the same techniques for a set of classes
that implement the ways to compute state sales tax by different states.
Pay careful attention to the relationships between the classes. In fact, grab
your pen and write the appropriate relationship (IS-A, HAS-A, and
IMPLEMENTS) on each arrow in the class diagram.
