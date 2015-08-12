require 'logger'

class Dojo

  def initialize
    @log = Logger.new(STDOUT)
    @log.level = Logger::WARN
  end


  #
  # +input+::
  #   Input should be "operator lhs rhs", ie: "+ 1 2"
  #
  def calculate(input)
    args = input.split(' ')
    operator = args.shift
    args = args.map {|val| val.to_i }
    @log.debug "Operator: #{operator} Args: #{args}"
    case operator
      when '+'
        args.reduce(:+)
      when '-'
        args.reduce(:-)
      when '*'
        args.reduce(:*)
      when '/'
        args.reduce(:/)
      when '%'
        args.reduce(:%)
    end

  end
end
