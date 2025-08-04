import React, { Component } from 'react';

class Counter extends Component {
  constructor() {
    super();
    this.state = {
      count: 0
    };
    this.increment = this.increment.bind(this);
    this.sayHello = this.sayHello.bind(this);
    this.incrementAndGreet = this.incrementAndGreet.bind(this);
    this.decrement = this.decrement.bind(this);
  }

  increment() {
    this.setState({ count: this.state.count + 1 });
  }

  decrement() {
    this.setState({ count: this.state.count - 1 });
  }

  sayHello() {
    alert('Hello! Have a great day!');
  }

  incrementAndGreet() {
    this.increment();
    this.sayHello();
  }

  render() {
    return (
      <div>
        <h2>Counter: {this.state.count}</h2>
        <button onClick={this.incrementAndGreet}>Increment</button>
        <button onClick={this.decrement}>Decrement</button>
      </div>
    );
  }
}

export default Counter;
