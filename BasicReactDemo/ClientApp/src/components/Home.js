import { Component } from 'react';
import { Disclaimer } from './Disclaimer';
import { SelectLabName } from './SelectLabName';

export class Home extends Component {
  static displayName = Home.name;

  render() {
      return (
          [
              <p key="hello">Hello</p>,
              <Disclaimer />,
              <SelectLabName />
          ]
      )
  }
}
