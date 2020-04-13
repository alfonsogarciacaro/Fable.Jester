﻿namespace Fable.FastCheck

open Fable.Core

type FastCheck =
    /// Run the property, throw in case of failure
    /// 
    /// It can be called directly from describe/it blocks of Mocha.
    /// It does not return anything in case of success.
    /// 
    /// WARNING: Has to be awaited
    /// Asynchronous property to be checked
    /// Optional parameters to customize the execution
    static member inline assert' (prop: AsyncProperty<'T>, ?parameters: Parameters<'T>) = Bindings.fc.assert'(prop, ?parameters = parameters)
    /// Run the property, throw in case of failure
    /// 
    /// It can be called directly from describe/it blocks of Mocha.
    /// It does not return anything in case of success.
    /// Synchronous property to be checked
    /// Optional parameters to customize the execution
    static member inline assert' (prop: Property<'T>, ?parameters: Parameters<'T>) = Bindings.fc.assert'(prop, ?parameters = parameters)
    
    /// Run asynchronous commands over a Model and the Real system
    ///
    /// Throw in case of inconsistency
    static member inline asyncModelRun (setup: Setup<'InitialModel,'Real>, commandIter: Iterable<Command<'Model,'Real,JS.Promise<unit>,JS.Promise<bool>>>) = Bindings.fc.asyncModelRun(setup, commandIter)
    /// Run asynchronous commands over a Model and the Real system
    ///
    /// Throw in case of inconsistency
    static member inline asyncModelRun (setup: Setup<'InitialModel,'Real>, commandIter: CommandsIterable<'Model,'Real,JS.Promise<unit>,JS.Promise<bool>>) = Bindings.fc.asyncModelRun(setup, commandIter)

    /// Instantiate a new AsyncProperty
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline asyncProperty (arb0: Arbitrary<'T0>, predicate: ('T0 ->JS.Promise<bool>)) = Bindings.fc.asyncProperty(arb0, predicate)
    /// Instantiate a new AsyncProperty
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline asyncProperty (arb0: Arbitrary<'T0>, predicate: ('T0 ->JS.Promise<unit>)) = Bindings.fc.asyncProperty(arb0, predicate)
    /// Instantiate a new AsyncProperty
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline asyncProperty (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, predicate: ('T0 -> 'T1 ->JS.Promise<bool>)) = Bindings.fc.asyncProperty(arb0, arb1, predicate)
    /// Instantiate a new AsyncProperty
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline asyncProperty (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, predicate: ('T0 -> 'T1 ->JS.Promise<unit>)) = Bindings.fc.asyncProperty(arb0, arb1, predicate)
    /// Instantiate a new AsyncProperty
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline asyncProperty (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, arb2: Arbitrary<'T2>, predicate: ('T0 -> 'T1 -> 'T2 ->JS.Promise<bool>)) = Bindings.fc.asyncProperty(arb0, arb1, arb2, predicate)
    /// Instantiate a new AsyncProperty
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline asyncProperty (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, arb2: Arbitrary<'T2>, predicate: ('T0 -> 'T1 -> 'T2 ->JS.Promise<unit>)) = Bindings.fc.asyncProperty(arb0, arb1, arb2, predicate)
    /// Instantiate a new AsyncProperty
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline asyncProperty (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, arb2: Arbitrary<'T2>, arb3: Arbitrary<'T3>, predicate: ('T0 -> 'T1 -> 'T2 -> 'T3 ->JS.Promise<bool>)) = Bindings.fc.asyncProperty(arb0, arb1, arb2, arb3, predicate)
    /// Instantiate a new AsyncProperty
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline asyncProperty (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, arb2: Arbitrary<'T2>, arb3: Arbitrary<'T3>, predicate: ('T0 -> 'T1 -> 'T2 -> 'T3 ->JS.Promise<unit>)) = Bindings.fc.asyncProperty(arb0, arb1, arb2, arb3, predicate)
    /// Instantiate a new AsyncProperty
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline asyncProperty (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, arb2: Arbitrary<'T2>, arb3: Arbitrary<'T3>, arb4: Arbitrary<'T4>, predicate: ('T0 -> 'T1 -> 'T2 -> 'T3 -> 'T4 ->JS.Promise<bool>)) = Bindings.fc.asyncProperty(arb0, arb1, arb2, arb3, arb4, predicate)
    /// Instantiate a new AsyncProperty
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline asyncProperty (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, arb2: Arbitrary<'T2>, arb3: Arbitrary<'T3>, arb4: Arbitrary<'T4>, predicate: ('T0 -> 'T1 -> 'T2 -> 'T3 -> 'T4 ->JS.Promise<unit>)) = Bindings.fc.asyncProperty(arb0, arb1, arb2, arb3, arb4, predicate)
    /// Instantiate a new AsyncProperty
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline asyncProperty (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, arb2: Arbitrary<'T2>, arb3: Arbitrary<'T3>, arb4: Arbitrary<'T4>, arb5: Arbitrary<'T5>, predicate: ('T0 -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 ->JS.Promise<bool>)) = Bindings.fc.asyncProperty(arb0, arb1, arb2, arb3, arb4, arb5, predicate)
    /// Instantiate a new AsyncProperty
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline asyncProperty (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, arb2: Arbitrary<'T2>, arb3: Arbitrary<'T3>, arb4: Arbitrary<'T4>, arb5: Arbitrary<'T5>, predicate: ('T0 -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 ->JS.Promise<unit>)) = Bindings.fc.asyncProperty(arb0, arb1, arb2, arb3, arb4, arb5, predicate)
    /// Instantiate a new AsyncProperty
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline asyncProperty (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, arb2: Arbitrary<'T2>, arb3: Arbitrary<'T3>, arb4: Arbitrary<'T4>, arb5: Arbitrary<'T5>, arb6: Arbitrary<'T6>, predicate: ('T0 -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 ->JS.Promise<bool>)) = Bindings.fc.asyncProperty(arb0, arb1, arb2, arb3, arb4, arb5, arb6, predicate)
    /// Instantiate a new AsyncProperty
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline asyncProperty (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, arb2: Arbitrary<'T2>, arb3: Arbitrary<'T3>, arb4: Arbitrary<'T4>, arb5: Arbitrary<'T5>, arb6: Arbitrary<'T6>, predicate: ('T0 -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 ->JS.Promise<unit>)) = Bindings.fc.asyncProperty(arb0, arb1, arb2, arb3, arb4, arb5, arb6, predicate)
    
    /// Run the property, do not throw contrary to assert'
    /// 
    /// WARNING: Has to be awaited
    /// Asynchronous property to be checked
    /// Optional parameters to customize the execution
    static member inline check (prop: AsyncProperty<'T>, ?parameters: Parameters<'T>) = Bindings.fc.check(prop, ?parameters = parameters)
    /// Run the property, do not throw contrary to assert'
    /// Synchronous property to be checked
    /// Optional parameters to customize the execution
    static member inline check (prop: Property<'T>, ?parameters: Parameters<'T>) = Bindings.fc.check(prop, ?parameters = parameters)

    /// Run synchronous commands over a Model and the Real system
    ///
    /// Throw in case of inconsistency
    static member modelRun (setup: Setup<'InitialModel,'Real>, commandIter: Iterable<Command<'Model,'Real,unit,bool>>) = Bindings.fc.modelRun(setup, commandIter)
    /// Run synchronous commands over a Model and the Real system
    ///
    /// Throw in case of inconsistency
    static member modelRun (setup: Setup<'InitialModel,'Real>, commandIter: CommandsIterable<'Model,'Real,unit,bool>) = Bindings.fc.modelRun(setup, commandIter)

    /// Instantiate a new Property
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline property (arb0: Arbitrary<'T0>, predicate: ('T0 -> bool)) = Bindings.fc.property(arb0, predicate)
    /// Instantiate a new Property
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline property (arb0: Arbitrary<'T0>, predicate: ('T0 -> unit)) = Bindings.fc.property(arb0, predicate)
    /// Instantiate a new Property
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline property (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, predicate: ('T0 -> 'T1 -> bool)) = Bindings.fc.property(arb0, arb1, predicate)
    /// Instantiate a new Property
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline property (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, predicate: ('T0 -> 'T1 -> unit)) = Bindings.fc.property(arb0, arb1, predicate)
    /// Instantiate a new Property
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline property (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, arb2: Arbitrary<'T2>, predicate: ('T0 -> 'T1 -> 'T2 -> bool)) = Bindings.fc.property(arb0, arb1, arb2, predicate)
    /// Instantiate a new Property
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline property (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, arb2: Arbitrary<'T2>, predicate: ('T0 -> 'T1 -> 'T2 -> unit)) = Bindings.fc.property(arb0, arb1, arb2, predicate)
    /// Instantiate a new Property
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline property (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, arb2: Arbitrary<'T2>, arb3: Arbitrary<'T3>, predicate: ('T0 -> 'T1 -> 'T2 -> 'T3 -> bool)) = Bindings.fc.property(arb0, arb1, arb2, arb3, predicate)
    /// Instantiate a new Property
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline property (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, arb2: Arbitrary<'T2>, arb3: Arbitrary<'T3>, predicate: ('T0 -> 'T1 -> 'T2 -> 'T3 -> unit)) = Bindings.fc.property(arb0, arb1, arb2, arb3, predicate)
    /// Instantiate a new Property
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline property (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, arb2: Arbitrary<'T2>, arb3: Arbitrary<'T3>, arb4: Arbitrary<'T4>, predicate: ('T0 -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> bool)) = Bindings.fc.property(arb0, arb1, arb2, arb3, arb4, predicate)
    /// Instantiate a new Property
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline property (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, arb2: Arbitrary<'T2>, arb3: Arbitrary<'T3>, arb4: Arbitrary<'T4>, predicate: ('T0 -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> unit)) = Bindings.fc.property(arb0, arb1, arb2, arb3, arb4, predicate)
    /// Instantiate a new Property
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline property (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, arb2: Arbitrary<'T2>, arb3: Arbitrary<'T3>, arb4: Arbitrary<'T4>, arb5: Arbitrary<'T5>, predicate: ('T0 -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> bool)) = Bindings.fc.property(arb0, arb1, arb2, arb3, arb4, arb5, predicate)
    /// Instantiate a new Property
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline property (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, arb2: Arbitrary<'T2>, arb3: Arbitrary<'T3>, arb4: Arbitrary<'T4>, arb5: Arbitrary<'T5>, predicate: ('T0 -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> unit)) = Bindings.fc.property(arb0, arb1, arb2, arb3, arb4, arb5, predicate)
    /// Instantiate a new Property
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline property (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, arb2: Arbitrary<'T2>, arb3: Arbitrary<'T3>, arb4: Arbitrary<'T4>, arb5: Arbitrary<'T5>, arb6: Arbitrary<'T6>, predicate: ('T0 -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> bool)) = Bindings.fc.property(arb0, arb1, arb2, arb3, arb4, arb5, arb6, predicate)
    /// Instantiate a new Property
    /// Assess the success of the property. Would be considered falsy if its throws or if its output evaluates to false
    static member inline property (arb0: Arbitrary<'T0>, arb1: Arbitrary<'T1>, arb2: Arbitrary<'T2>, arb3: Arbitrary<'T3>, arb4: Arbitrary<'T4>, arb5: Arbitrary<'T5>, arb6: Arbitrary<'T6>, predicate: ('T0 -> 'T1 -> 'T2 -> 'T3 -> 'T4 -> 'T5 -> 'T6 -> unit)) = Bindings.fc.property(arb0, arb1, arb2, arb3, arb4, arb5, arb6, predicate)
    
    /// Generate an array containing all the values that would have been generated during assert' or check
    /// Integer representing the number of values to generate or Parameters as in assert'
    static member inline sample (generator: Arbitrary<'T>, ?parameters: Parameters<'T>) = Bindings.fc.sample(generator, ?parameters = parameters) |> List.ofSeq
    /// Generate an array containing all the values that would have been generated during assert' or check
    /// Integer representing the number of values to generate or Parameters as in assert'
    static member inline sample (generator: Arbitrary<'T>, ?parameters: int) = Bindings.fc.sample(generator, ?parameters = parameters) |> List.ofSeq
    /// Generate an array containing all the values that would have been generated during assert' or check
    /// Integer representing the number of values to generate or Parameters as in assert'
    static member inline sample (generator: IProperty<'T,'Return>, ?parameters: Parameters<'T>) = Bindings.fc.sample(generator, ?parameters = parameters) |> List.ofSeq
    /// Generate an array containing all the values that would have been generated during assert' or check
    /// Integer representing the number of values to generate or Parameters as in assert'
    static member inline sample (generator: IProperty<'T,'Return>, ?parameters: int) = Bindings.fc.sample(generator, ?parameters = parameters) |> List.ofSeq
        
    /// Run asynchronous and scheduled commands over a Model and the Real system
    ///
    /// Throw in case of inconsistency
    static member scheduledModelRun (scheduler: Scheduler<'T,'TArgs>, setup: Setup<'InitialModel,'Real>, commandIter: Iterable<Command<'Model,'Real,JS.Promise<unit>,JS.Promise<bool>>>) = Bindings.fc.scheduledModelRun(scheduler, setup, commandIter)
    /// Run asynchronous and scheduled commands over a Model and the Real system
    ///
    /// Throw in case of inconsistency
    static member scheduledModelRun (scheduler: Scheduler<'T,'TArgs>, setup: Setup<'InitialModel,'Real>, commandIter: CommandsIterable<'Model,'Real,JS.Promise<unit>,JS.Promise<bool>>) = Bindings.fc.scheduledModelRun(scheduler, setup, commandIter)

    /// Gather useful statistics concerning generated values
    /// 
    /// Print the result in `console.log` or `params.logger` (if defined)
    /// Classifier function that can classify the generated value in zero, one or more categories (with free labels)
    /// Integer representing the number of values to generate or Parameters as in assert'
    static member inline statistics (generator: Arbitrary<'T>, classify: ('T -> string), ?parameters: Parameters<'T>) = Bindings.fc.statistics(generator, classify, ?parameters = parameters)
    /// Gather useful statistics concerning generated values
    /// 
    /// Print the result in `console.log` or `params.logger` (if defined)
    /// Classifier function that can classify the generated value in zero, one or more categories (with free labels)
    /// Integer representing the number of values to generate or Parameters as in assert'
    static member inline statistics (generator: Arbitrary<'T>, classify: ('T -> string), ?parameters: int) = Bindings.fc.statistics(generator, classify, ?parameters = parameters)
    /// Gather useful statistics concerning generated values
    /// 
    /// Print the result in `console.log` or `params.logger` (if defined)
    /// Classifier function that can classify the generated value in zero, one or more categories (with free labels)
    /// Integer representing the number of values to generate or Parameters as in assert'
    static member inline statistics (generator: Arbitrary<'T>, classify: ('T -> ResizeArray<string>), ?parameters: Parameters<'T>) = Bindings.fc.statistics(generator, classify, ?parameters = parameters)
    /// Gather useful statistics concerning generated values
    /// 
    /// Print the result in `console.log` or `params.logger` (if defined)
    /// Classifier function that can classify the generated value in zero, one or more categories (with free labels)
    /// Integer representing the number of values to generate or Parameters as in assert'
    static member inline statistics (generator: Arbitrary<'T>, classify: ('T -> ResizeArray<string>), ?parameters: int) = Bindings.fc.statistics(generator, classify, ?parameters = parameters)
    /// Gather useful statistics concerning generated values
    /// 
    /// Print the result in `console.log` or `params.logger` (if defined)
    /// Classifier function that can classify the generated value in zero, one or more categories (with free labels)
    /// Integer representing the number of values to generate or Parameters as in assert'
    static member inline statistics (generator: IProperty<'T,'Return>, classify: ('T -> string), ?parameters: Parameters<'T>) = Bindings.fc.statistics(generator, classify, ?parameters = parameters)
    /// Gather useful statistics concerning generated values
    /// 
    /// Print the result in `console.log` or `params.logger` (if defined)
    /// Classifier function that can classify the generated value in zero, one or more categories (with free labels)
    /// Integer representing the number of values to generate or Parameters as in assert'
    static member inline statistics (generator: IProperty<'T,'Return>, classify: ('T -> string), ?parameters: int) = Bindings.fc.statistics(generator, classify, ?parameters = parameters)
    /// Gather useful statistics concerning generated values
    /// 
    /// Print the result in `console.log` or `params.logger` (if defined)
    /// Classifier function that can classify the generated value in zero, one or more categories (with free labels)
    /// Integer representing the number of values to generate or Parameters as in assert'
    static member inline statistics (generator: IProperty<'T,'Return>, classify: ('T -> ResizeArray<string>), ?parameters: Parameters<'T>) = Bindings.fc.statistics(generator, classify, ?parameters = parameters)
    /// Gather useful statistics concerning generated values
    /// 
    /// Print the result in `console.log` or `params.logger` (if defined)
    /// Classifier function that can classify the generated value in zero, one or more categories (with free labels)
    /// Integer representing the number of values to generate or Parameters as in assert'
    static member inline statistics (generator: IProperty<'T,'Return>, classify: ('T -> ResizeArray<string>), ?parameters: int) = Bindings.fc.statistics(generator, classify, ?parameters = parameters)
    
    /// Create a Stream based on `g`
    /// Underlying data of the Stream
    static member inline stream (g: IterableIterator<'T>) = Bindings.fc.stream(g)
    
    /// Convert any value to its fast-check string representation
    /// Value to be converted into a string
    static member inline stringify (value: 'T) = Bindings.fc.stringify(value)
    