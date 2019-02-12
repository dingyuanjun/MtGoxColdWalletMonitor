import React, { Component } from 'react';

export class FetchData extends Component {
    displayName = FetchData.name;

    constructor(props) {
        super(props);
        this.state = { 
            balance : "0", 
            loading: true 
        };

        fetch('api/BlockchainData/GetBalance/12T4oSNd4t9ty9fodgNd47TWhK35pAxDYN')
        .then(response => {
            return response.text();
        })
        .then(balance => {
            this.setState({
                balance : balance,
                loading: false
            });
        });
    }

    static renderBalance(balance) {
        return (
            <table className='table'>
                <thead>
                    <tr>
                        <th>Balance</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                        <td>{balance}</td>
                    </tr>
                </tbody>
            </table>
        );
    }

    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : FetchData.renderBalance(this.state.balance);

        return (
            <div>
                <h1>Sample address balance</h1>
                {contents}
            </div>
        );
    }
}
