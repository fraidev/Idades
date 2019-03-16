import React, { Component } from 'react';

export class Home extends Component {
  static displayName = Home.name;

  constructor(props) {
    super(props);
    this.state = { idade: -1,  valueInput: "" };
    this.handleChange = this.handleChange.bind(this);
    this.handleSubmit = this.handleSubmit.bind(this);
  }

  handleChange(event) {
    this.setState({ valueInput: event.target.value });
  }

  handleSubmit(event) {
    this.isRegistered(this.state.valueInput).then(x =>
      console.log(this.state.idade));
    event.preventDefault();
  }

  render() {
    var result = this.state.idade != -1 ? "Sua idade é " + this.state.idade + "!" : "Não sei" 
    return (
      <div>
        <form onSubmit={this.handleSubmit}>
          <label>
            <p>Escreva seu nome aqui:</p>
            <input type="text" name="name" value={this.state.valueInput} onChange={this.handleChange} />
          </label>
          <input type="submit" value="Submit" />
        </form>
        <div> {result} </div>
      </div>
    );
  }

  async isRegistered(nome) {
    const response = await fetch('api/Pessoa/IsRegistered/' + nome);
    const data = await response.json();
    this.setState({ idade: data });
  }
}
