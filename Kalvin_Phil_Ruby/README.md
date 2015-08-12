
RSpec
=====

We're running rspec, just because that's what I tend to use most.

The language is a DSL, but it reads quite well.  See the (Inbuilt Matcher)[https://relishapp.com/rspec/rspec-expectations/v/3-3/docs/built-in-matchers] docs for some examples.

Success
-------

On Success, you'll see something like this:

    box:~$ rspec
    
    .............
    
    Finished in 0.00881 seconds (files took 0.3723 seconds to load)
    13 examples, 0 failures

Failure
-------

If something goes wrong, it gives quite a nice error report:

    box:~$ rspec
    
    .FF........F.
    
    Failures:
    
      1) Dojo adds three and four
         Failure/Error: expect(@dojo.calculate("+ 3 4")).to eq(7)
           
           expected: 7
                got: 3
           
           (compared using ==)
         # ./spec/lib/calculator_spec.rb:13:in `block (2 levels) in <top (required)>'
    
    ...    
