import React, { Component } from 'react';

export class SelectLabName extends Component {
    /*static displayName = LabName.name;*/

    constructor(props) {
        super(props);
        this.state = { labnames: [], loading: true };
    }

    componentDidMount() {
        this.populateLabRecords();
    }

    static renderLabNames() {
        return (<p>MOCK LAB NAMES</p>
        );
    }

    render() {
        let contents = <p><em>Loading...</em></p>
        if (!this.state.loading) {
            contents = this.renderLabNames();
        }

        return (
            <div>
                {contents}
          </div>
        );
    }

    async populateLabRecords() {
        const response = await fetch('LabRecords');
        const data = await response.json();
        this.setState({ labrecords: data, loading: false });
    }
}
