import React, { Component } from 'react';
import { Box, Text } from 'grommet';

export class Disclaimer extends Component {
    static displayName = Disclaimer.name;

    constructor(props) {
        super(props);
    }

    render() {
        return (
            <Box direction="row-responsive" gap="medium" align="center">
                <Box
                    align="center"
                    border={{ color: 'yellow', size: 'medium' }}
                    pad="small"
                    round="small"
                    width="large"
                    background="status-warning"
                >
                    <Text
                        style={{ fontFamily: 'Georgia', fontStyle: 'italic', fontSize: 'small'}}
                    >
                        This is a software engineering demonstration and is not intended to be a source of medical information.</Text>
                </Box>
            </Box>
        );
    }
}
